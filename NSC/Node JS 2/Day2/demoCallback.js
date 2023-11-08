let data;
function taskOne(callback){
    setTimeout(()=>{
    data = "This is my data";
    callback(data);
},3000)
}

function taskTwo(value){
    console.log("data: ", value);
}

taskOne(taskTwo);
