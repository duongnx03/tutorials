#include <stdio.h>

int main() {
    int num, count = 1 , sum = 0;

    printf("Enter a positive integer: ");
    scanf("%d", &num);

    while (count <= num ) { 
      if (count < num) {
        printf("%d + ", count);
      }else{
        printf("%d = ", count);
      }
        sum += count;
        ++count;
    }

    printf("%d", sum);
    return 0;
}
