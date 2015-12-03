using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissFile.Core
{
    public abstract class FileTask<T> where T : FileTaskResult
    {
        #region Properties

        public DateTime StartedAtUTC { get; private set; }
        public T Result { get; private set; }
        public decimal Progress { get; protected set; }

        #endregion

        #region Events

        public delegate void ExecutionStartedDelegate();
        public event ExecutionStartedDelegate ExecutionStarted;
        protected void OnExecutionStarted()
        {
            if (ExecutionStarted != null)
            {
                Try(() => { ExecutionStarted(); });
            }
        }

        public delegate void ProgressUpdatedDelegate();
        public event ProgressUpdatedDelegate ProgressUpdated;
        protected void OnProgressUpdated()
        {
            if (ProgressUpdated != null)
            {
                Try(() => { ProgressUpdated(); });
            }
        }
        
        public delegate void ExecutionCompletedDelegate(T result);
        public event ExecutionCompletedDelegate ExecutionCompleted;
        protected void OnExecutionCompleted(T result)
        {
            if (ExecutionCompleted != null)
            {
                Try(() => { ExecutionCompleted(result); });
            }
        }

        public delegate void ErrorDelegate(Exception e);
        public event ErrorDelegate Error;
        protected void OnError(Exception e)
        {
            if (Error != null)
            {
                Try(() => { Error(e); });
            }
        }

        #endregion

        #region Abstract methods

        protected abstract T ExecuteInternal();

        #endregion
        
        #region Internal methods

        public void ExecuteAsync()
        {
            Task.Run(() => { Execute(); });
        }
        
        public T Execute()
        {
            Progress = 0;
            StartedAtUTC = DateTime.UtcNow;
            OnExecutionStarted();

            try
            {
                Result = ExecuteInternal();
                if (Result.Exception != null)
                {
                    OnError(Result.Exception);
                }
                OnExecutionCompleted(Result);
            }
            catch (Exception e)
            {
                OnError(e);
            }

            Progress = 1;
            return Result;
        }

        #endregion

        #region Private methods

        private bool Try(Action action)
        {
            try
            {
                action();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        protected void Run (T result, Action action)
        {
            try
            {
                action();
            }
            catch (Exception e)
            {
                result.Exception = e;
            }
        }

        #endregion
    }
}
