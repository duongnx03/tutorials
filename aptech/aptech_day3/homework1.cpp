#include <stdio.h>

int main(){
  int num, count = 0;

  printf("Input num:\n");
  scanf("%d", &num);

  while (count <= num)
  {
    printf("%d\n", count);
    count+=2;
  }
  // while (count <= num)
  // {
  //   if (count % 2 == 0) {
  //     printf("Even number is: %d\n", count);
  //   }count += 1; 
  // }
}
