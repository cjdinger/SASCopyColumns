/*
 * Copy Columns task
 * Copyright 2015 SAS Institute
 * Support: Chris Hemedinger
 * http://blogs.sas.com/sasdummy
 * Purpose:
     To copy the column names from a data set so that you can paste the names into another
     document: such as a SAS program or Excel spreadsheet.

     There are three versions of the task; each version copies the column names in a slightly 
     different way. 
       1. Copy Column Names (new lines) - copies the names as a list with each column name on 
          a separate line.

       2. Copy Column Names (comma list) - copies the names as a comma-separated list, all
          on a single line

       3. Copy Column Names (new lines with commas) - copies the names as a list with 
          each column name on a separate line, with a comma between each name
*/
using System;
using System.Text;
using SAS.Shared.AddIns;
using SAS.Tasks.Toolkit;

namespace SASCopyColumns
{
    // unique identifier for this task
    [ClassId("20bae62e-8f75-4a31-8ec2-c4f1fb422a90")]
    // location of the task icon to show in the menu and process flow
    [IconLocation("SASCopyColumns.task.ico")]
    [InputRequired(InputResourceType.Data)]
    public class SASCopyColumnsTask : SAS.Tasks.Toolkit.SasTask
    {
        #region Initialization
        public SASCopyColumnsTask()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.TaskCategory = "Data Utilities";
            this.TaskDescription = "Copy the column names from the active data set";
            this.TaskName = "Copy Column Names (comma list)";

        }
        #endregion

        #region overrides

        /// <summary>
        /// Show the task user interface
        /// </summary>
        /// <param name="Owner"></param>
        /// <returns>whether to cancel the task, or run now</returns>
        public override ShowResult Show(System.Windows.Forms.IWin32Window Owner)
        {
            ISASTaskData2 ds = this.Consumer.InputData[0] as ISASTaskData2;
            string[] listColNames;
            if (ds.Accessor.Open())
            { 
                ds.Accessor.ColumnNames(out listColNames);
                for (int i = 0; i < listColNames.Length; i++)
                    listColNames[i] = SAS.Tasks.Toolkit.Helpers.UtilityFunctions.SASValidLiteral(listColNames[i]);
                ds.Accessor.Close();
                string list = string.Join(", ", listColNames);
                System.Windows.Forms.Clipboard.SetText(list);
            }

            return ShowResult.Canceled;
        }

        #endregion

    }

    // unique identifier for this task
    [ClassId("56F932CB-DA4C-4E4E-9BF0-95BE41911BEF")]
    // location of the task icon to show in the menu and process flow
    [IconLocation("SASCopyColumns.task.ico")]
    [InputRequired(InputResourceType.Data)]
    public class SASCopyColumnsTaskList : SAS.Tasks.Toolkit.SasTask
    {
        #region Initialization
        public SASCopyColumnsTaskList()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.TaskCategory = "Data Utilities";
            this.TaskDescription = "Copy the column names from the active data set";
            this.TaskName = "Copy Column Names (new lines)";

        }
        #endregion

        #region overrides

        /// <summary>
        /// Show the task user interface
        /// </summary>
        /// <param name="Owner"></param>
        /// <returns>whether to cancel the task, or run now</returns>
        public override ShowResult Show(System.Windows.Forms.IWin32Window Owner)
        {
            ISASTaskData2 ds = this.Consumer.InputData[0] as ISASTaskData2;
            string[] listColNames;
            if (ds.Accessor.Open())
            {
                ds.Accessor.ColumnNames(out listColNames);
                for (int i = 0; i < listColNames.Length; i++)
                    listColNames[i] = SAS.Tasks.Toolkit.Helpers.UtilityFunctions.SASValidLiteral(listColNames[i]);
                ds.Accessor.Close();
                string list = string.Join("\n", listColNames);
                System.Windows.Forms.Clipboard.SetText(list);
            }

            return ShowResult.Canceled;
        }

        #endregion
    }

    // unique identifier for this task
    [ClassId("6FE149A5-31AC-46ED-88F8-6D5B953804FB")]
    // location of the task icon to show in the menu and process flow
    [IconLocation("SASCopyColumns.task.ico")]
    [InputRequired(InputResourceType.Data)]
    public class SASCopyColumnsTaskListCommas : SAS.Tasks.Toolkit.SasTask
    {
        #region Initialization
        public SASCopyColumnsTaskListCommas()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.TaskCategory = "Data Utilities";
            this.TaskDescription = "Copy the column names from the active data set";
            this.TaskName = "Copy Column Names (new lines with commas)";

        }
        #endregion

        #region overrides

        /// <summary>
        /// Show the task user interface
        /// </summary>
        /// <param name="Owner"></param>
        /// <returns>whether to cancel the task, or run now</returns>
        public override ShowResult Show(System.Windows.Forms.IWin32Window Owner)
        {
            ISASTaskData2 ds = this.Consumer.InputData[0] as ISASTaskData2;
            string[] listColNames;
            if (ds.Accessor.Open())
            {
                ds.Accessor.ColumnNames(out listColNames);
                for (int i = 0; i < listColNames.Length; i++ )
                   listColNames[i] = SAS.Tasks.Toolkit.Helpers.UtilityFunctions.SASValidLiteral(listColNames[i]);
                ds.Accessor.Close();
                string list = string.Join("\n, ", listColNames);
                System.Windows.Forms.Clipboard.SetText(list);
            }

            return ShowResult.Canceled;
        }

        #endregion
    }
}
