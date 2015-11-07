The Copy Column Names tasks
----------------------------------
Purpose:
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

To Use:
  Open the data source that you're interested in. Select 
  Tools->Add-In->Data Utilities and then select the method of Copy operation 
  that you want.  No window is shown, but the column names will be copied
  to the Windows clipboard.  You can then paste the content into a SAS 
  program window, text editor, or spreadsheet.
 
Installing the Custom Task
----------------------------------------
The custom task is in this assembly (DLL): SasCopyColumns.dll. 

To install the custom task for use with SAS Enterprise Guide 4.3 or later, 
you simply need to copy the DLL to a designated directory (slightly different
for each version of SAS Enterprise Guide):

- For use by just the current user, copy the DLL to: 
     %appdata%\SAS\EnterpriseGuide\4.3\Custom 
	 %appdata%\SAS\EnterpriseGuide\5.1\Custom 
	 %appdata%\SAS\EnterpriseGuide\6.1\Custom 
	 %appdata%\SAS\EnterpriseGuide\7.1\Custom 

  where %appdata% is a Windows environment variable that resolves to your profile area. 
  You might need to create the “Custom” subfolder in this area.

- For use by all users on a machine, copy the DLL to: 
  %programfiles%\SAS\EnterpriseGuide\4.3\Custom 
  %programfiles%\SAS\EnterpriseGuide\5.1\Custom 
  %programfiles%\SAS\EnterpriseGuide\6.1\Custom 
  %programfiles%\SAS\EnterpriseGuide\7.1\Custom 

  You might need to create the “Custom” subfolder in this area. 
  You might need elevated privileges on your machine to copy content into the Program Files area.

If you downloaded the task from the SAS website, you might also need to Unblock the 
DLL on your system to allow SAS Enterprise Guide to access it.  Microsoft Windows
has a security feature that prevents downloaded DLL files from working until you unblock them.
See instructions here:
  http://blogs.sas.com/content/sasdummy/unblocking-custom-task-dlls/

After the file is copied into place, restart SAS Enterprise Guide. 
The tasks should be available from the Tools->Add-In->Data Utilities.