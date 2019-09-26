function verify(){
    var a,b,c,d,e,f;
    a=document.getElementById("userid").value;
    b=document.getElementById("Pass").value;
    c=document.getElementById("Pass1").value;
    d=document.getElementById("name").value;
    e=document.getElementById("dob").value;
    f=document.getElementById("zip").value;
   var g=document.getElementById("country").value;
   var h=document.getElementById("email").value;
   var i=document.getElementById("sex1");
   var j=document.getElementById("sex2");
   var k=document.getElementById("c1");
   var l=document.getElementById("c2");  
   var mailformat = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
   var namecheck=/^[a-zA-Z ]{5,30}$/
   if(d.match(namecheck)){
   }
   else{
       var x="galti";
   }
   if(h.match(mailformat))
      {
      }
    else
        {
      var t="galat";     
        }
   if((a=="")&&(b=="")&&(c=="")&&(d=="")&&(e=="")&&(f=="")){
          alert("Multiple Fields Missing");
     } else{
     if((a=="")||(a.length<5)||(a.length>12)){
       document.getElementById("p1").innerHTML="*ID Error";
    }
    if((b=="")||(b.length<7)||(b.length>12)){
     document.getElementById("p2").innerHTML="*Password Error";
    }
     if((c=="")||(c!=b)){
        document.getElementById("p3").innerHTML="*Confirm Password Error";
    }
     if((d=="")||(x=="galti")){              
     document.getElementById("p4").innerHTML="*Name Error";
 }
    if(e==""){                  
     document.getElementById("p5").innerHTML="*DOB Missing";
    }
    if(e.split("-",1)>2001)
                {
                    document.getElementById("p5").innerHTML="*Under Age";
                }

    if(g=="Please Select a Country"){                  
     document.getElementById("p7").innerHTML="*Country Missing";
    }
    if((f=="")||(f.length!=6)){
     document.getElementById("p8").innerHTML="*ZIP Code Error";
    }
    if((h=="")||(t=="galat")){
     document.getElementById("p9").innerHTML="*Email-Id Error";
    }
    if((i.checked == false)&&(j.checked==false)){
        document.getElementById("p10").innerHTML="*Sex must be selected";
    }
    if((k.checked == false)&&(l.checked==false)){
        document.getElementById("p11").innerHTML="*Language must be selected";
    }


     }
 }