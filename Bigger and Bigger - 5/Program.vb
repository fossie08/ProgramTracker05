'
' Created by SharpDevelop.
' User: 19ofoster
' Date: 11/10/2021
' Time: 10:08
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Module Program
	Sub Main()
		'Dimesions variables
		Dim num1 As Double = 0
		Dim num2 As Double = 0
		Dim num3 As Double = 0
		Dim answer As Double = 0
		
		'Asks te user for some data
		Console.WriteLine("Please enter 3 numbers . . . ")
		num1 = Val(Console.ReadLine())
		num2 = Val(Console.ReadLine())
		num3 = Val(Console.ReadLine())
		
		answer = If(
                    (num1 > num2 AndAlso num1 > num3), num1, If((num2 > num1 AndAlso num2 > num3), num2, num3)
                   )
        Console.WriteLine("Largest Number is . . . " & answer)
		
		Console.Write("Press any key to continue . . . ")
		Console.ReadKey(True)
	End Sub
End Module
