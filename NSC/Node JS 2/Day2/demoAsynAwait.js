async function taskOne(){
    await new Promise(resolve =>{
        setTimeout(() => {
            console.log("Task two is running");
            resolve();
        }, 5000);
    })
}

function taskTwo(){
    console.log("Task two is running");
}

async function runTask(){
    try{
        await taskOne();
        taskTwo();
    }catch(error){
        console.log("error: ", error);
    }
}

runTask()