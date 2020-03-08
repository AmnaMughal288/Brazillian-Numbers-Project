using System;
using static System.Console;
using static System.Math;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
			
			
			
			
			
//~ ask user for an integer number n !
//~ loop over each base b = n-1... all the way to 2


	//~ 1. n % b
	//~ 2. counter = 0
	//~ 3. digitsAresame = true
	//~ loop over digits of n in  base b, loop stops if n is not greater than 0 or digitsAreSame becomes false
		//~ n%b gives one digit
		//~ n/b discards rightmost digit
		//~ counter ++
		//~ if current digit not same, digitsAreSame = false
		
	//~ after this loop we need to know 3 things:
	//~ 1. are all the digits the same
	//~ 2. what is the digit
	//~ 3. what is the digit
	
	
	//~ ask user for an integer number n !
            Write("Enter a positive integer:");
            int n = int.Parse(ReadLine( ));
           
    //~ loop over each base b = n-1... all the way to 2
            for (int b = n-1; b > 1; b --)
            {  	
				int counter = 0;
				int z = n;
				bool digitAreSame = true;
				bool notDone = true;
				
				//~ 1. n % b
				int r = n%b;
				
				while(digitAreSame && notDone)
				{
					z = z/b;
					int newr = z%b;
				
					if (newr == r)
					
					{
						counter ++;
						
					}else if (z == 0)
					{
						notDone = false;
					}
					else  
					{
						digitAreSame = false;
					}
				}
			if (digitAreSame)
				{
					Write($"{n} in base 10 is ");
				
				for(int i = 0; i <= counter; i++)
				{
					if(i == counter)
					{
						Write(r+" ");
					}
					else
					{
						Write(r + ",");
					}
				}
			WriteLine($"in base {b}");
		}
	}
					
					
					
			
		
				}
			}
			}
				
			
					

		

	

