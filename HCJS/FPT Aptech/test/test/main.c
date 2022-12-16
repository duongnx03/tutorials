
//
//  main.c
//  test
//
//  Created by mac on 10/20/22.
//

#include <stdio.h>

int main(){
    int a, b, c, result;
    printf("Input a: ");
    scanf("%d", &a);
    
    printf("Input b: ");
    scanf("%d", &b);
    
    printf("Input c: ");
    scanf("%d", &c);
    
    result = a + b + c;
    
    if(result >= 50){
        printf("%d is greater than 50", result);
    }
    
    if(result <= 50){
        if(result >= 30){
            printf("\n%d is less than 50", result);
        }
    }
    
    if(result <= 30){
        printf("\n%d is less than 30", result);
    }
    printf("\nend");
    return 0;
}
