  
  
alter  TRIGGER [dbo].[UContact]  
ON [dbo].[Contact]  
FOR UPDATE  
AS  
BEGIN  
 set nocount on 
    INSERT INTO ContactHistory(  
   lContactId,  
   sMnemonic,  
   sDescription,  
   lApplicationUserId,  
   bActive,  
   dteAmended,  
   lAmendedById,  
   lProcessId,  
   sMachineName,  
   sActionPerformed)  
    SELECT I.lContactId,  
   I.sMnemonic,  
   I.sDescription,  
   I.lApplicationUserId,  
   I.bActive,  
   I.dteAmended,  
   I.lAmendedById,  
   I.lProcessId,  
   I.sMachineName,  
   'UPDATED'  
 FROM   inserted I  
 INNER JOIN Contact C ON I.lContactId = C.lContactId  
    IF @@ERROR <> 0  
    BEGIN   
        PRINT 'ERROR: Failed to write to History Table; rollback in progress'  
        ROLLBACK TRANSACTION  
    END  
  
    RETURN  
  
END  
  
 go
  
  ALTER  TRIGGER [dbo].[UContactDetail]  
ON [dbo].[ContactDetail]  
FOR UPDATE  
AS  
BEGIN  
set nocount on
    INSERT INTO ContactDetailHistory(  
   lContactDetailId,  
   lContactId,  
   lContactSalutationId,  
   sFirstName,  
   sMiddleName,  
   sLastName,  
   sSuffix,  
   sTitle,  
   sNickName,  
   sDepartment,  
   sURL,  
   dteEffectiveDate,  
   sAddressLine1,  
   sAddressLine2,  
   sAddressLine3,  
   lCityId,  
   sCounty,  
   lStateId,  
   sPostCode,  
   lCountryId,  
   sComments,  
   sEmail1,  
   sEmail2,  
   sPhoneMain,  
   sPhoneOffice,  
   sPhoneMobile,  
   sPhoneHome,  
   sPhoneFax,  
   sPhonePager,  
   sPhoneTelex,  
   sPhoneTelexAnswerBack,  
   dteAmended,  
   lAmendedById,  
   bActive,  
   sActionPerformed)  
    SELECT I.lContactDetailId,  
   I.lContactId,  
   I.lContactSalutationId,  
   I.sFirstName,  
   I.sMiddleName,  
   I.sLastName,  
   I.sSuffix,  
   I.sTitle,  
   I.sNickName,  
   I.sDepartment,  
   I.sURL,  
   I.dteEffectiveDate,  
   I.sAddressLine1,  
   I.sAddressLine2,  
   I.sAddressLine3,  
   I.lCityId,  
   I.sCounty,  
   I.lStateId,  
   I.sPostCode,  
   I.lCountryId,  
   I.sComments,  
   I.sEmail1,  
   I.sEmail2,  
   I.sPhoneMain,  
   I.sPhoneOffice,  
   I.sPhoneMobile,  
   I.sPhoneHome,  
   I.sPhoneFax,  
   I.sPhonePager,  
   I.sPhoneTelex,  
   I.sPhoneTelexAnswerBack,  
   I.dteAmended,  
   I.lAmendedById,  
   I.bActive,  
   'UPDATED'  
 FROM   Inserted I  
         INNER JOIN ContactDetail C ON I.lContactId = C.lContactId  
            AND I.lContactDetailId = C.lContactDetailId  
  
    IF @@ERROR <> 0  
    BEGIN   
        PRINT 'ERROR: Failed to write to History Table; rollback in progress'  
        ROLLBACK TRANSACTION  
    END  
  
    RETURN  
  
END  
  
  
  
  GO
    
  ALTER  trigger dbo.[UApplicationUser] on [dbo].[ApplicationUser]    
for update    
as    
begin    
  set nocount on  
 update AU    
 set AU.sDescription = case  when isnull(AU.sFirstName,'') + isnull(AU.sLastName,'') = '' then AU.sUserName    
     when isnull(AU.sFirstName,'') = isnull(AU.sLastName,'') then AU.sFirstName -- 2005-10-14 Ali Celik : Added this.    
     else ltrim(isnull(AU.sFirstName,'') + ' ' + isnull(AU.sLastName,''))    
      end    
 from Inserted I, ApplicationUser AU    
 where AU.lApplicationUserId = I.lApplicationUserId    
    
 insert into ApplicationUserHistory(lApplicationUserId, sLoginId, sUserName, lBusinessUnitId, lUserId, dteAmended, lAmendedById, lProcessId, sMachineName, bActive,  
  sDescription, lApplicationUserTypeId, vbPassword, lTradingEntityId, lApplicationUserStatusId, lLoginFailures, dteLastLogin, sFirstname,  
  sLastName, lAuthenticationType, sInitials  ) -- RWE - inserted to store audit information    
 select lApplicationUserId, sLoginId, sUserName, lBusinessUnitId, lUserId, dteAmended, lAmendedById, lProcessId, sMachineName, bActive,  
  sDescription, lApplicationUserTypeId, vbPassword, lTradingEntityId, lApplicationUserStatusId, lLoginFailures, dteLastLogin, sFirstname,  
  sLastName, lAuthenticationType, sInitials    
 from Inserted    
end    
    