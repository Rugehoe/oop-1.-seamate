using System;

int[] myNumbers = {0, 10, 40 ,20 ,30};
int[] highNum = {0, 0};




for(int i = 0; i<myNumbers.Length; i++){

	if(highNum[0]<myNumbers[i]){

	highNum[0] = myNumbers[i];
	highNum[1] = i;

	}
}

Console.WriteLine("highest number is " + highNum[0]);
Console.WriteLine("and is found in index " + highNum[1]);

