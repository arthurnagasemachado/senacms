using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
	class Program
	{
		
		static void Main(string[] args)
		{
    		bool playerOneWin = true;
    		bool playerTwoWin = false;
    		int roundsPlayerOne = 0;
    		int roundsPlayerTwo = 0;
    		
    		// Fazer estrutura condicional aqui
    		if (playerOneWin == true)
    		{
    		    roundsPlayerOne ++;
    		}
    		
    		else
    		{
    		    roundsPlayerTwo ++;
    		}
    		  
		    Console.Write("Player 1: ");
		    Console.WriteLine(roundsPlayerOne);
		    Console.Write("Player 2: ");
		    Console.WriteLine(roundsPlayerTwo);
		}
	}
}
