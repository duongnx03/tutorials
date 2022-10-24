#include <iostream>

int main(){
  int mark;

  printf("Input mark: \n");
  scanf("%d", &mark);

  if(mark >= 90){
    printf("So good\n");
  }else if(mark >= 75){
    printf("Good\n");
  }else if(mark >= 40){
    printf("Bad\n");
  }else{
    printf("So Bad\n");
  }
}
