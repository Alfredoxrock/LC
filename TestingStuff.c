#include <stdio.h>

void addone (int *n){
	// n is a pointer here which point to a memory-address outside the function
	(*n)++; // this will effectively increment the values of n
}

int main()
{	
	int n;
	printf("Before: %d\n", n);
	addone(&n);
	printf("After: %d\n", n);
	return 0;
}