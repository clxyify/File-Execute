public void FileExecute(string direc)//direc is the script directory
{
   if (File.Exists(direct))//check if directory exists
   {
       string readscript = File.ReadAllText(direc);//read the file
       if (readscript == "") { File.WriteAllText(direc, "Script was not readable."); } else { API.Execute(readscript); }//run the file
   }
   else//if it doesnt exist, we will create one
   {
       File.Create(direc);//create the file
       //File.WriteAllText(direc, "print('hello from file execute')");
   }
}
