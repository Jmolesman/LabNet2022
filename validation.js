function obligatoryFields()  
{
    hidePumpkingImage();

    let first_name = document.getElementById("first_name").value;
    let last_name = document.getElementById("last_name").value;

    if (first_name == "" && last_name == "")  
    {  
        document.getElementById("pumpkin_first_name").style.visibility = 'visible';
        document.getElementById("pumpkin_last_name").style.visibility = 'visible';
        alert("Debe completar la casila del nombre y la del apellido");  
        return false;  
    }
    else if (first_name == "")
    {
        document.getElementById("pumpkin_first_name").style.visibility = 'visible';
        alert("Debe completar la casila del nombre");  
        return false; 
    }
    else if(last_name == "")
    {
        document.getElementById("pumpkin_last_name").style.visibility = 'visible';
        alert("Debe completar la casila del apellido");  
        return false; 
    }
    return true;
} 

function clearDataFields()
{
    hidePumpkingImage();
    document.getElementById("first_name").value = "";
    document.getElementById("last_name").value = "";
    document.getElementById("date_of_birth").value = "";
    document.getElementById("email_field").value = "";
    document.getElementById("company_department").value = "";
}

function hidePumpkingImage()
{
    document.getElementById("pumpkin_first_name").style.visibility = 'hidden';
    document.getElementById("pumpkin_last_name").style.visibility = 'hidden';
}
