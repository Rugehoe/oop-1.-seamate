using System;

float[] rads = {1.0f, 3.0f, 5.0f};
float[] areal = new float[3];

for(int i = 0; i<3; i++)
{

	areal[i] = (float) Math.PI * rads[i] * rads[i];
	Console.WriteLine("Areal is " + areal[i]);

}

float arealTotal =  areal[0] + areal[1] + areal[2];

Console.WriteLine("total areal is " + arealTotal);

