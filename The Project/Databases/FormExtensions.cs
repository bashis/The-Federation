using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FormExtensions
{
    /// <summary>
    /// Thread Safe Helper
    /// </summary>
    public static class FormExtensions
    {
        /// <summary>
        /// Thread-safely executes the action on the control.
        /// 
        /// If the provided delegate is executed on another thread,
        /// the calling thread waits for the execution to complete.
        /// </summary>
        /// <typeparam name="T">Type of the control.</typeparam>
        /// <param name="control">The control on which the action is executed.</param>
        /// <param name="action">The executed action. The argument is the control itself.</param>
        public static void ThreadSafe<T>(this T control, Action<T> action) where T : Control
        {
            if (control == null)
                throw new ArgumentNullException("control");

            if (action == null)
                throw new ArgumentNullException("action");

            if (control.InvokeRequired)
                control.Invoke(action, control);
            else
                action(control);
        }

        /// <summary>
        /// Thread-safely executes the action on the control.
        /// 
        /// If the provided delegate is executed on another thread,
        /// the calling thread does not wait for the execution to complete.
        /// </summary>
        /// <typeparam name="T">Type of the control.</typeparam>
        /// <param name="control">The control on which the action is executed.</param>
        /// <param name="action">The executed action. The argument is the control itself.</param>
        public static void ThreadSafeBegin<T>(this T control, Action<T> action) where T : Control
        {
            if (control == null)
                throw new ArgumentNullException("control");

            if (action == null)
                throw new ArgumentNullException("action");

            if (control.InvokeRequired)
                control.BeginInvoke(action, control);
            else
                action(control);
        }

       /// <summary>
       /// Hides Auto Complete Suggestions
       /// </summary>
       /// <param name="textBox"></param>
        public static void HideAutoCompleteSuggestions(this TextBox textBox)
        {
            // big hack
            bool focus = textBox.Focused;
            textBox.Hide();
            textBox.Show();
            if (focus)
                textBox.Focus();
        }

        /// <summary>
        /// Safely shows a <see cref="System.Windows.Forms.Form"/> with a parent
        /// <see cref="System.Windows.Forms.IWin32Window"/> if one provided.
        /// </summary>
        /// <param name="form">
        /// An instance of <see cref="System.Windows.Forms.Form"/> to make visible.
        /// </param>
        /// <param name="parent">
        /// An implementation of <see cref="System.Windows.Forms.IWin32Window"/> to serve as parent, or null.
        /// </param>
        public static void SafeShow(this Form form, IWin32Window parent)
        {
            if (parent != null)
                form.Show(parent);
            else
                form.Show();
        }

        /// <summary>
        /// Safely shows a <see cref="System.Windows.Forms.Form"/> as a dialog box with a parent
        /// <see cref="System.Windows.Forms.IWin32Window"/> if one provided.
        /// </summary>
        /// <param name="form">
        /// An instance of <see cref="System.Windows.Forms.Form"/> to make visible.
        /// </param>
        /// <param name="parent">
        /// An implementation of <see cref="System.Windows.Forms.IWin32Window"/> to serve as parent, or null.
        /// </param>
        public static void SafeShowDialog(this Form form, IWin32Window parent)
        {
            if (parent != null)
                form.ShowDialog(parent);
            else
                form.ShowDialog();
        }
    }
}