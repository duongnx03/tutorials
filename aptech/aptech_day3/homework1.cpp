#include <stdio.h>

int main(){
  int num, count;

  printf("Input num:\n");
  scanf("%d", &num);

  count = 0;
  while (count <= num)
  {
    if (count % 2 == 0) {
      printf("Even number is: %d\n", count);
    }count += 1; 
  }
}
