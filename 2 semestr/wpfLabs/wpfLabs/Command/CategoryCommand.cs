using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace wpfLabs.Command
{
    public class CategoryCommand : ICommand
    {
        private Action<object> execute;
        private Func<object, bool> canExecute;


        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }

        }
        public CategoryCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return this.canExecute == null || this.canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            this.execute(parameter);
        }

        public void RaiseCanExecuteChanged()
        {
      //      CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
            /* static void Undo()
         {
             if (undoHistory.Count == 0) return;
             var undo = undoHistory.Pop();
             UndoCommand.RaiseCanExecuteChanged();
             // Обернуто для того чтобы в случае исключения флаг всё равно снимался
             try
             {
                 isUndoProcess = true;
                 undo.Obj.GetType().GetProperty(undo.Prop).SetValue(undo.Obj, undo.OldValue);
             }
             finally
             {
                 isUndoProcess = false;
             }
         }

         static void Redo()
         {
             if (redoHistory.Count == 0) return;
             var redo = redoHistory.Pop();
             RedoCommand.RaiseCanExecuteChanged();
             try
             {
                 isRedoProcess = true;
                 redo.Obj.GetType().GetProperty(redo.Prop).SetValue(redo.Obj, redo.OldValue);
             }
             finally
             {
                 isRedoProcess = false;
             }
         }

         static void SaveHistory(object obj, string propertyName, object value)
         {
             if (isUndoProcess)
             {
                 redoHistory.Push((obj, propertyName, value));
                 RedoCommand.RaiseCanExecuteChanged();
             }
             else if (isRedoProcess)
             {
                 undoHistory.Push((obj, propertyName, value));
                 UndoCommand.RaiseCanExecuteChanged();
             }
             else
             {
                 undoHistory.Push((obj, propertyName, value));
                 UndoCommand.RaiseCanExecuteChanged();
                 redoHistory.Clear();
                 RedoCommand.RaiseCanExecuteChanged();
             }
         }

         static void ClearHistory()
         {
             undoHistory.Clear();
             UndoCommand.RaiseCanExecuteChanged();
             redoHistory.Clear();
             RedoCommand.RaiseCanExecuteChanged();
         }*/


        //=

    }
}
