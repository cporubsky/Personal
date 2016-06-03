import java.io.*;
import java.util.*;

import org.apache.poi.ss.usermodel.Cell;
import org.apache.poi.ss.usermodel.Row;
import org.apache.poi.xssf.usermodel.XSSFSheet;
import org.apache.poi.xssf.usermodel.XSSFWorkbook;

public class Practice {

	/**
	 * @param args
	 */
	public static void main(String[] args){
		
		String logFile = "log.txt";
		Logger logger = new Logger(logFile);;
		Scanner scanner = new Scanner(System.in);
		System.out.print("Enter a file: ");
		
		//user input
		String fileName = scanner.nextLine();
		
		if (!fileName.isEmpty()){
			try {
				
				//get file
				File file = new File(fileName + ".xlsx");
				
				
				if(file.exists()){
					logger.logPoints("Job Starting.", true);
					
					//create workbook
					XSSFWorkbook workBook = new XSSFWorkbook(new FileInputStream(file));
					
					//get sheet from workbook
					XSSFSheet sheet = workBook.getSheetAt(0);
						
					int rows = sheet.getPhysicalNumberOfRows();
					
					//process Excel file
					processExcel(sheet, logger, rows);
						
					//close connections
					workBook.close();
					//input.close();
					logger.logPoints("Job Completed Successfully.", false);
					return;
				}	
				
				logger.log("No input file found.", true);			
				return;
					
			}
			catch(Exception ex){
				logger.log(ex.toString(), true);	
			}
		}	
		logger.log("No file entered.", true); 
		return;	
	}
	
	/**
	 * 
	 * @param sheet current sheet in workbook
	 */
	public static void processExcel(XSSFSheet sheet, Logger logger, int rows){
		
		int count = 0;
		for(Row row : sheet) {
			//skip first row
			if(row.getRowNum() != 0){
				for(Cell cell : row){
					
					//evaluate cell
					switch(cell.getCellType()){
					
					//numeric cell
					case Cell.CELL_TYPE_NUMERIC:
						System.out.print((int)cell.getNumericCellValue() + " ");
						break;
					
					//string cell
					case Cell.CELL_TYPE_STRING:
						System.out.print(cell.getStringCellValue() + " ");
						break;
						
					default:
						System.out.println("in default");
						count--;
						break;
					}		
				}
				count++;
				System.out.println();
			}	
		} 	
		String s = count + "/" + (rows - 1) + " processed successfully.";
		logger.log(s);		
	}
}
