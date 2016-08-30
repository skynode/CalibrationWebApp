using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CalibrationWebApp.Models.DB;
using CalibrationWebApp.Models.ViewModel;

namespace CalibrationWebApp.Models.EntityManager
{
    public class UserManager
    {
        public void AddUserAccount(UserSignUpView user)
        {
            using(Tools_Registry_Entities dbEntities = new Tools_Registry_Entities())
            {
                //calibration system user
                SYSUser systemUser = new  SYSUser();
                systemUser.LoginName = user.LoginName;
                systemUser.PasswordHash = user.Password;
                systemUser.RowCreatedSYSUSerID = user.SYSUserID > 0 ? user.SYSUserID : 1;
                systemUser.RowModifiedSYSUserID = user.SYSUserID > 0 ? user.SYSUserID : 1;
                systemUser.RowCreatedDateTime = DateTime.Now;
                systemUser.RowModifiedDateTime = DateTime.Now;

                dbEntities.SYSUsers.Add(systemUser);
                dbEntities.SaveChanges();

                //Employee Profile
                EmployeeProfile employeeProfile = new EmployeeProfile();
                employeeProfile.SYSUserID = user.SYSUserID;
                employeeProfile.FirstName = user.FirstName;
                employeeProfile.LastName = user.LastName;
                employeeProfile.EmailAddress = user.EmailAddress;
                employeeProfile.Location = user.CurrentLocation;
                employeeProfile.RowCreatedSYSUserID = user.SYSUserID > 0 ? user.SYSUserID : 1;
                employeeProfile.RowModifiedSYSUserID = user.SYSUserID > 0 ? user.SYSUserID : 1;
                employeeProfile.RowCreatedDateTime = DateTime.Now;
                employeeProfile.RowModifiedDateTime = DateTime.Now;

                dbEntities.EmployeeProfiles.Add(employeeProfile);
                dbEntities.SaveChanges();

                if(user.LOOKUPRoleID > 0)
                {
                    SYSUserRole sysRole = new SYSUserRole();
                    sysRole.LOOKUPRoleID = user.LOOKUPRoleID;
                    sysRole.SYSUserID = user.SYSUserID;
                    sysRole.IsActive = true;
                    sysRole.RowCreatedSYSUserID = user.SYSUserID > 0 ? user.SYSUserID : 1;
                    sysRole.RowModifiedSYSUserID = user.SYSUserID > 0 ? user.SYSUserID : 1;
                    sysRole.RowCreatedDateTime = DateTime.Now;
                    sysRole.RowModifiedDateTime = DateTime.Now;

                    dbEntities.SYSUserRoles.Add(sysRole);
                    dbEntities.SaveChanges();
                }
            }
        }

        public bool IsLoginExist(string loginName)
        {
            using(Tools_Registry_Entities dbEntities = new Tools_Registry_Entities())
            {
                return dbEntities.SYSUsers.Where(su => su.LoginName.Equals(loginName)).Any();
            }
        }
    }
}