#include <stdio.h>

int main() {
    int num, count , sum = 0;

    printf("Enter a positive integer: ");
    scanf("%d", &num);
    count = 1;

    while (count <= num ) {
        sum += count;
        ++count;
    }

    printf("Sum = %d", sum);
    return 0;
}
