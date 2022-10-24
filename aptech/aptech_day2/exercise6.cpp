#include <iostream>

int main(){
  int a, b;

  printf("Input a: \n");
  scanf("%d", &a);

  printf("Input b: \n");
  scanf("%d", &b);

  if(a > b){
    printf("%d is greater than %d\n", a, b);
  }else if(a < b){
    printf("%d is less than %d\n", a, b);
  }else{
    printf("%d = %d\n", a, b);
  }
}
