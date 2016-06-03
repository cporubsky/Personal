import java.text.SimpleDateFormat;
import java.util.*;
import java.io.*;

public class Logger {

private File log;
	
	//default constructor
	public Logger(){
		
	}
	
	//constructor
	public Logger(String fileName){
		log = new File(fileName);
	}
	
	//logs date and message
	public void log(String s, boolean error){
		try{
			FileWriter fileWriter = new FileWriter(this.log, true);
			Date date = new Date();
			SimpleDateFormat formatDate = new SimpleDateFormat("E MM.dd.yyyy 'at' hh.mm.ss a zzz | ");
			
			if(error == true){
				fileWriter.write("---------------------------");
				fileWriter.write(System.getProperty("line.separator"));
				fileWriter.write(formatDate.format(date) + s);
				fileWriter.write(System.getProperty("line.separator"));
				System.out.println("Error recorded. Check log.");
				fileWriter.write("---------------------------");
				fileWriter.write(System.getProperty("line.separator"));
			}
			else{
				System.out.println("Job completed successfully.");		
			}	
			fileWriter.close();	
		}
		catch(Exception ex){
			System.out.println(ex.toString());
		}
	}
	
	    //logs date and message
		public void log(String s){
			try{
				FileWriter fileWriter = new FileWriter(this.log, true);
				Date date = new Date();
				SimpleDateFormat formatDate = new SimpleDateFormat("E MM.dd.yyyy 'at' hh.mm.ss a zzz | ");
				fileWriter.write(formatDate.format(date) + s);
				fileWriter.write(System.getProperty("line.separator"));
				fileWriter.close();		
			}
			catch(Exception ex){
				System.out.println(ex.toString());
			}
		}
	
	public void logPoints(String s, boolean start){
		try{
			if(start == true){
				FileWriter fileWriter = new FileWriter(this.log, true);
				Date date = new Date();
				SimpleDateFormat formatDate = new SimpleDateFormat("E MM.dd.yyyy 'at' hh.mm.ss a zzz | ");
				
				fileWriter.write("---------------------------");
				fileWriter.write(System.getProperty("line.separator"));
				fileWriter.write(formatDate.format(date) + s);
				fileWriter.write(System.getProperty("line.separator"));
				fileWriter.close();
			}
			else{
				FileWriter fileWriter = new FileWriter(this.log, true);
				Date date = new Date();
				SimpleDateFormat formatDate = new SimpleDateFormat("E MM.dd.yyyy 'at' hh.mm.ss a zzz | ");
				fileWriter.write(formatDate.format(date) + s);
				fileWriter.write(System.getProperty("line.separator"));
				fileWriter.write("---------------------------");
				fileWriter.write(System.getProperty("line.separator"));
				fileWriter.close();
			}		
		}
		catch(Exception ex){
			System.out.println(ex.toString());
		}
	}	
}
