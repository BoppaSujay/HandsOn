function addingnumber()
{
    var a=parseInt($("#text1").val());
    var b=parseInt($("#text2").val());
    if (a>=0 && b>=0)
    {
        var c=a+b;
        $("#text3").val(c);
        $("#div1").html(c).css("color","green").css("font-size","20px");
    } 
    else
    {
        $("#div1").html("Pls.Enter the Value").css("color","red");
    }
}