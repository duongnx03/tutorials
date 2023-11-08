function fetchData(){
    return new Promise(function(resolve, reject){
        setTimeout(function(){
            const data = "this is data from server";
            if(true){
                resolve(data);
            }else{
                reject("erro from get data");
            }
        }, 2000);
    })
}

function processData(data){
return new Promise(function(resolve, reject){
    setTimeout(function(){
        const processData = data.toUpperCase();
        resolve(processData);
    }, 3000);
})
}

function displayResult(result){
    console.log("data: ",result);
}

//su dung middleware
fetchData()
    .then(function(data){
        return processData(data);
    })
    .then(function(processData){
        return displayResult(processData);
    })
    .catch(function(error){
       console.log("error: ", error);
    })
