private static void WriteResult(int[][,] inputMatrices, string operation)
		{
            // assumed this was to be all in one function
            const int firstMatrix = 0;
            const int secondMatrix = 1;
            const int column = 1;
            const int row = 0;
            var columnLengthFirstMatrix = inputMatrices[firstMatrix].GetLength(column);
            var rowLengthFirstMatrix = inputMatrices[firstMatrix].GetLength(row);
            var columnLengthSecondMatrix = inputMatrices[secondMatrix].GetLength(column);
            var rowLengthSecondMatrix = inputMatrices[secondMatrix].GetLength(row);
            var result = new int[rowLengthFirstMatrix, columnLengthSecondMatrix];

            switch (operation)
		    {
		        case "multiply":
		   		       
                    if (columnLengthFirstMatrix != rowLengthSecondMatrix)
		            {
                        Console.WriteLine("These matrices cannot be multiplied");
		                break;
		            }

                    for (var firstMatrixRow = 0; firstMatrixRow < inputMatrices[firstMatrix].GetLength(row); firstMatrixRow++)
                    {
                        for (var currentColumnSecondMatrix = 0; currentColumnSecondMatrix < columnLengthSecondMatrix; currentColumnSecondMatrix++) {
                            var temp = 0;
                            for (var currentColumnFirstMatrix = 0; currentColumnFirstMatrix < columnLengthFirstMatrix; currentColumnFirstMatrix++)
                            {

                               temp = temp +  inputMatrices[firstMatrix][firstMatrixRow, currentColumnFirstMatrix] * inputMatrices[secondMatrix][
                               currentColumnFirstMatrix, currentColumnSecondMatrix];                                              
                            }
                            result[firstMatrixRow, currentColumnSecondMatrix] = temp;
                        }
                    }

                    break;
                case "divide":

                    Console.WriteLine("entered divide");
                    break;
                case "sum":

                    Console.WriteLine("entered sum");
                    break;
                case "subtract":

                    Console.WriteLine("entered subtract");
                    break;
            }
            // print results to screen
            var rowLength = result.GetLength(0);
            var colLength = result.GetLength(1);

            for (var i = 0; i < rowLength; i++)
            {
                for (var j = 0; j < colLength; j++)
                {
                    Console.Write($"| {result[i, j]} | ");
                }
                Console.Write(System.Environment.NewLine);
                Console.WriteLine("______________________________");
            }
        }