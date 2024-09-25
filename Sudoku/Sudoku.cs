using System;

bool Correct = true;


int[,] Sudoku = {

	{3,9,1,2,8,6,5,7,4},
	{4,8,7,3,5,9,1,2,6},
	{6,5,2,7,1,4,8,3,9},
	{8,7,5,4,3,1,6,9,2},
	{2,1,3,9,6,7,4,8,5},
	{9,6,4,5,2,8,7,1,3},
	{1,4,9,6,7,3,2,5,8},
	{5,3,8,1,4,2,9,6,7},
	{7,2,6,8,9,5,3,4,1}

};

for(int i=0; i<Sudoku.GetLength(0); i++){

int[] SudokuLine = {0,0,0,0,0,0,0,0,0};
int[] OnLine = {0,0,0,0,0,0,0,0,0};
bool correctLine = true;

        for(int j=0; j<Sudoku.GetLength(0); j++){
	   SudokuLine[j] = Sudoku[j,i];
                
        }

	for(int j=0; j<SudokuLine.Length; j++){
	
		for(int u=0; u<SudokuLine.Length; u++ ){
		
			if(SudokuLine[j] == OnLine[u]){
			Correct = false;
			correctLine = false;
			Console.WriteLine("Line(V)Fail");
			Console.WriteLine((i+1) + " , " + SudokuLine[j]);
			}
		}
	
		if(correctLine == true){
		OnLine[j] = SudokuLine[j];
		}		
		
	}
}

for(int i=0; i<Sudoku.GetLength(0); i++){

int[] SudokuLine = {0,0,0,0,0,0,0,0,0};
int[] OnLine = {0,0,0,0,0,0,0,0,0};
bool correctLine = true;

        for(int j=0; j<Sudoku.GetLength(0); j++){
           SudokuLine[j] = Sudoku[i,j];

        }

        for(int j=0; j<SudokuLine.Length; j++){

                for(int u=0; u<SudokuLine.Length; u++ ){

                        if(SudokuLine[j] == OnLine[u]){
                        Correct = false;
                        correctLine = false;
			Console.WriteLine("Line(H)Fail");
                        Console.WriteLine((i+1) + " , " + SudokuLine[j]);
                        }
                }

                if(correctLine == true){
                OnLine[j] = SudokuLine[j];
                }
        }
}


for(int i = 0; i<9; i++) {
int[,] SudokuBox = {
	{0,0,0},
	{0,0,0},
	{0,0,0}
};
int[] OnLine = {0,0,0,0,0,0,0,0,0};
bool correctLine = true;
int JumpX = i%3;
int JumpY = i/3;

		for(int j = 0; j<9; j++){
			SudokuBox[j/3,j%3] = Sudoku[(j/3)+(JumpX*3),(j%3)+(JumpY*3)];
			}


for(int j = 0; j<9; j++){
		   for(int u=0; u<9; u++ ){

                        if(SudokuBox[j/3,j%3] == OnLine[u]){
                        Correct = false;
                        correctLine = false;
			Console.WriteLine("BoxFail");
                        Console.WriteLine((i+1) + " , " + SudokuBox[u/3,u%3]);
                        }
		   }
			if(correctLine == true){
			OnLine[j] = SudokuBox[j/3,j%3];

			}
		}
}


if(Correct == false){
Console.WriteLine("Fail");
} else {
Console.WriteLine("Correct");
}
