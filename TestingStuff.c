/******************************************************************************

                            Online C Compiler.
                Code, Compile, Run and Debug C program online.
Write your code in this editor and press "Run" button to compile and execute it.

*******************************************************************************/

#include <stdio.h>
#include<conio.h>

int main()
{
    char str[100];
    printf("Enter any String: ");
    gets(str);
    printf("\nYou've entered: %s", str);
    getch();
    return 0;
}