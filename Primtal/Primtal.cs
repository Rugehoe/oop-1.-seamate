using System;


float divtime = 0;
int highNum = 0;

for(int i = -1; i<1000000; i += 2){

	for(int u =1; u<i+1; u += 2){
	
		if(i % u == 0){
		divtime++;
		}
	}

	if(divtime == 2 ){
	highNum = i;
	}
divtime = 0;
}
Console.WriteLine(highNum);
