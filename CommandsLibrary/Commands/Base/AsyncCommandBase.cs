﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandsLibrary.Commands.Base
{
    /// <summary>
    /// We use that base class to give insructions to load/make commands. Work with database
    /// </summary>
    public abstract class AsyncCommandBase : CommandBase
    {
        
        private bool _isExecuting;
        
        private bool IsExecuting 
        { 
            get { return _isExecuting; }
            set { _isExecuting = value; OnCanExecuteChanged(); }
        }

        public override bool CanExecute(object? parameter)
        {
            return !IsExecuting;
        }

        public override async void Execute(object? parameter)
        {
            IsExecuting = true;

            try
            {
                await ExecuteAsync(parameter);
            }
            finally
            {

                IsExecuting = false;
            }
        }

        public abstract Task ExecuteAsync(object? parameter);
    }
}
