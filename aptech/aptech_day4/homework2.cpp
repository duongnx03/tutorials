#include <stdio.h>

int main(){
  int num, count = 0, i;

  printf("Input num: \n");
  scanf("%d", &num);

  if (num < 2 ) {
    printf("%d isn't a prime number. \n", num);
    return 0;
  }

  for ( i = 2; i <= num / 2; i++) {
    if (num % i ==0) {
      count++;
    }
  }
  if (count == 0) {
    printf("%d is a prime number. \n", num);
  }else {
    printf("%d isn't a prime number. \n", num);
    return 0;
  }
}

