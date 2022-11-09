#include <stdio.h>
#include <string.h>
#include <stdlib.h>

// int main(){
//   int a, b, c = 0, sum1 = 0, sum2 = 0;
//
//   printf("Input a: \n");
//   scanf("%d", &a);
//   printf("Input :\n");
//   scanf("%d", &b);
//
//   c = a + 1;
//   while (a <= b)
//   {
//     sum1 += a;
//     a += 2;
//   }
//
//   while (c <= b)
//   {
//     sum2 += c;
//     c += 2;
//   }
//
//   if (a % 2 == 0) {
//     printf("sum of even numbers: %d\n", sum1);
//     printf("sum of odd numbers: %d\n", sum2);
//   }else{
//     printf("sum of even numbers: %d\n", sum2);
//     printf("sum of odd numbers: %d\n", sum1);
//   }
// }

int main(){
  int a, b, sum_of_even = 0, sum_of_odd = 0;
  char output1[] = "";
  char output2[] = "";
  char tmp[100] = "";

  printf("Input a: \n");
  scanf("%d", &a);
  printf("Input b:\n");
  scanf("%d", &b);


  while (a <= b)
  {
    if (a % 2 == 0) {
      sum_of_even += a;
      sprintf(tmp, "%d + ", a);
      strcat(output1, tmp);
    } else {
      sum_of_odd += a;
      sprintf(tmp, "%d + ", a);
      strcat(output2, tmp);
    }
    a += 1;
  }

  printf("expression: %s= %d\n", output1, sum_of_even);
  printf("expression: %s= %d\n", output2, sum_of_odd);

  return 0;
}


// int main() { 
//
//   int myAge = 20;
//
//   int* ptr_of_myAge;
//
//   ptr_of_myAge = &myAge;
//
//   printf("pointer of myAge: %p \n", &myAge);
//   printf("pointer variable: %p", ptr_of_myAge);
//
//
//
//   return 0;
// }
