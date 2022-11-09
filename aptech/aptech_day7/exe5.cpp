#include <stdio.h>
int sum(int a, int b){
  return a + b;
}
  
int sub(int a, int b){
  return a - b;
}
 
int mul(int a, int  b){
  return a * b;
}

float dev(float a, float b){
  return a / b;
}
void menu(){
  printf("*******************\n");
  printf("* 1. Sum          *\n");
  printf("* 2. Sub          *\n");
  printf("* 3. Mul          *\n");
  printf("* 4. Dev          *\n");
  printf("* 5. Exit         *\n");
  printf("*******************\n");
}

int main(){
  int option, a, b;
  do
  {
    menu();
    printf("Input option: \n");
    scanf("%d", &option);
    printf("Input a: \n");
    scanf("%d", &a);
    printf("Input b: \n");
    scanf("%d", &b);
    switch (option) {
      case 1: 
        printf("%d + %d = %d\n", a, b, sum(a, b));
        break;
      case 2: 
        printf("%d - %d = %d\n", a, b, sub(a, b));
        break;
      case 3:
        printf("%d * %d = %d\n", a, b, mul(a, b));
        break;
      case 4:
        printf("%d / %d = %f\n", a, b, dev(a, b));
        break;
      case 5:
        printf("Exit program.\n");
      default:
        printf("\n");
        break;
    }
  } while(option != 5);
}

