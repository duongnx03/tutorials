//
//  main.m
//  test
//
//  Created by mac on 11/5/22.
//
#include <stdio.h>
#include <string.h>
#include <malloc.h>

int main(){
  int a, b, sum_of_even = 0, sum_of_odd = 0;
  char output1[] = "a: ";
  char output2[] = "b: ";
  char tmp[1000];
  // int bytes = 12;

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
      // snprintf(tmp, bytes, "%d + ", a);
    } else {
      sum_of_odd += a;
      sprintf(tmp, "%d + ", a);
      strcat(output2, tmp);
      // snprintf(tmp, bytes, "%d + ", a);
    }
    a += 1;
  }

  printf("expression: %s= %d\n", output1, sum_of_even);
  printf("expression: %s= %d\n", output2, sum_of_odd);
  return 0;
}
