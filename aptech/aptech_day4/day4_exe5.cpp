#include <stdio.h>

int main(){
  int a, b, c = 0, sum1 = 0, sum2 = 0;


  printf("Input a: \n");
  scanf("%d", &a);
  printf("Input :\n");
  scanf("%d", &b);

  c = a + 1;
  while (a <= b)
  {
    if (a < b-1) {
      printf("%d + ", a);
    }else {
      printf("%d = ", a);
    }
    sum1 += a;
    a += 2;
  }
  printf("%d\n", sum1);

  while (c <= b)
  {
    if(c < b-1){
      printf("%d + ", c);

    }else {
      printf("%d = ", c);
    }
    sum2 += c;
    c += 2;
  }printf("%d\n", sum2);
  if (a % 2 == 0) {
    printf("sum of even numbers: %d\n", sum1);
    printf("sum of odd numbers: %d\n", sum2);
  }else{
    printf("sum of even numbers: %d\n", sum2);
    printf("sum of odd numbers: %d\n", sum1);
  }
}
