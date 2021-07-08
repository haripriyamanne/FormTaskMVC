Create procedure spAddEmployee
(    
	@FirstName varchar(50),
	@LastName varchar(50),
	@Email varchar(50) ,
	@PhoneNumber bigint,
	@Gender varchar(50),
	@CompanyName varchar(50),
	@CompanyType varchar(50),
	@CompanyLimited varchar(50),
	@CompanyWebsite varchar(50),
	@Busineess varchar(50),
	@Benifits varchar(50),
	@ListProducts varchar(50),
	@TrustElements varchar(50),
	@ImportantAreas varchar(50),
	@WebsiteExample varchar(50) 
)    
as     
Begin     
    Insert into Employees(FirstName,LastName,Email,PhoneNumber,Gender,CompanyName,CompanyType,CompanyLimited,CompanyWebsite,Busineess,Benifits,ListProducts,
	TrustElements,ImportantAreas,WebsiteExample ) 
    Values (@FirstName,@LastName,@Email,@PhoneNumber,@Gender,@CompanyName,@CompanyType,@CompanyLimited,@CompanyWebsite,@Busineess,@Benifits,@ListProducts,
	@TrustElements,@ImportantAreas,@WebsiteExample )   
End

Create procedure spGetAllEmployees    
as    
Begin    
    select *    
    from Employees
    order by Id    
End