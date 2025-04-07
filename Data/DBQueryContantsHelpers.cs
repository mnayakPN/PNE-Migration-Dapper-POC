internal static class DBQueryContantsHelpers
{
    public static string insertCustomerSql = @"INSERT INTO Customers (TenantId,CompanyId,CustomerShort,FirstName,LastName,MiddleName,
                                                    Email,Deleted,Imported,ImportId,IsBouncedEmail,CustomerNumber,Gender,Birthday,Anniversary,CountryCode,
                                                    CreatedOn,UpdatedOn)VALUES (@TenantId,@CompanyId,@CustomerShort,@FirstName,@LastName,@MiddleName,@Email,
                                                    @Deleted,@Imported,@ImportId,@IsBouncedEmail,@CustomerNumber,@Gender,@Birthday,@Anniversary,@CountryCode,@CreatedOn,@UpdatedOn)";

    public static string deleteCustomerSql = @"DELETE FROM dbo.Customers WHERE Id = @Id";

    public static string updateCustomerSql = @"UPDATE dbo.Customers SET TenantId = @TenantId,
                                                    CompanyId = @CompanyId,CustomerShort = @CustomerShort,FirstName = @FirstName,LastName = @LastName,MiddleName = @MiddleName,
                                                    Email = @Email,Deleted = @Deleted,Imported = @Imported,ImportId = @ImportId,IsBouncedEmail = @IsBouncedEmail,CustomerNumber = @CustomerNumber,
                                                    Gender = @Gender,Birthday = @Birthday,Anniversary = @Anniversary,CountryCode = @CountryCode,
                                                    UpdatedOn = @UpdatedOn WHERE Id = @Id";
}