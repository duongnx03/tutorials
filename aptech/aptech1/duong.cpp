#include <iostream>

// Use this command to compile the source code 
// g++ -o ./<name_of_execute_file> ./<code_files>.cpp
// Then run the program: ./<name_of_execute_file>

int main(){
  // khai bao bien a
  int a;
  // khai bao bien b
  int b, sum;
  printf("Input a: ");
  scanf("%d", &a );
  printf("number a is: %d", a);

  printf("\nInput b: ");
  scanf("%d", &b);
  printf("number b is: %d", b);

  sum = a + b;
  printf("\nSum of a and b is: %d", sum);
}
