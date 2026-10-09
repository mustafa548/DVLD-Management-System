using System;
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsUser
    {
        enum enMode { enAddNewUserMode, enUpdateUserInfoMode };

        private enMode Mode;

        private string _PasswordHash;

        public int UserID { get; set; }
        public string UserName { get; set; }

        public string PasswordHash
        {
            get
            {
                return _PasswordHash;
            }
        }

        public int PersonID { get; set; }
        public bool IsActive { get; set; }
        public clsPerson PersonInfo { get; set; }

        public int Attempts { get; set; }

        public DateTime? PasswordBlockedUntil { get; set; }

        public DateTime? LastAttemptAt { get; set; }

        public clsUser()
        {
            UserID       = -1;
            UserName     = "";
            _PasswordHash = "";
            PersonID     = -1;
            IsActive     = false;
            Attempts     = 3;
            PasswordBlockedUntil = null;
            LastAttemptAt = null;

            PersonInfo = null;

            Mode = enMode.enAddNewUserMode;
        }

        private clsUser(int UserID, string UserName, string PasswordHash, int PersonID,
            bool IsActive, int Attempts, DateTime? PasswordBlockedUntil, DateTime? LastAttemptAt)
        {
            this.UserID   = UserID;
            this.UserName = UserName;
            this._PasswordHash = PasswordHash;
            this.PersonID = PersonID;
            this.IsActive = IsActive;
            this.Attempts = Attempts;
            this.PasswordBlockedUntil = PasswordBlockedUntil;
            this.LastAttemptAt = LastAttemptAt;

            this.PersonInfo = clsPerson.Find(PersonID);

            Mode = enMode.enUpdateUserInfoMode;
        }

        public static DataTable GetAllUsers()
        {
            return clsDataAccessUser.GetAllUsers();
        }

        public static clsUser Find(int UserID)
        {
            string UserName     = "";
            string PasswordHash = "";
            int PersonID        = -1;
            bool IsActive       = false;
            int Attempts        = 3;
            DateTime? PasswordBlockedUntil = null;
            DateTime? LastAttemptAt = null;

            if (clsDataAccessUser.GetUserByID(UserID, ref UserName, ref PasswordHash, ref PersonID, ref IsActive, ref Attempts, ref PasswordBlockedUntil, ref LastAttemptAt))
            {
                return new clsUser(UserID, UserName, PasswordHash, PersonID, IsActive, Attempts, PasswordBlockedUntil, LastAttemptAt);
            }
            else
                return null;
        }

        public static clsUser Find(string UserName)
        {
            int UserID = -1;
            string PasswordHash = "";
            int PersonID = -1;
            bool IsActive = false;
            int Attempts = 3;
            DateTime? PasswordBlockedUntil = null;
            DateTime? LastAttemptAt = null;

            if (clsDataAccessUser.GetUserByUserName(ref UserID, UserName, ref PasswordHash, ref PersonID, ref IsActive, ref Attempts, ref PasswordBlockedUntil, ref LastAttemptAt))
            {
                return new clsUser(UserID, UserName, PasswordHash, PersonID, IsActive, Attempts, PasswordBlockedUntil, LastAttemptAt);
            }
            else
                return null;
        }

        public static bool DeleteUser(int UserID)
        {
            if (clsUser.Find(UserID).UserName == "Admin")
                return false;

            return clsDataAccessUser.DeleteUser(UserID);
        }

        private bool _AddNewUser()
        {   
            this.UserID = clsDataAccessUser.AddNewUser(this.UserName, this.PasswordHash, this.PersonID, this.IsActive);

            return this.UserID != -1;
        }

        private bool _UpdateUser()
        {
            if (this.UserName != "Admin" || !this.IsActive)
                return false;

            return clsDataAccessUser.UpdateUserInfo(this.UserID, this.UserName, this.PasswordHash, this.PersonID, this.IsActive, this.Attempts, this.PasswordBlockedUntil, this.LastAttemptAt);
        }

        public bool Save(string PasswordWithoutHashing = null)
        {
            if (PasswordWithoutHashing != null)
                this._PasswordHash = clsPasswordServices.HashPassword(PasswordWithoutHashing);

            switch (Mode)
            {
                case enMode.enAddNewUserMode:
                    if (_AddNewUser())
                    {
                        Mode = enMode.enUpdateUserInfoMode;
                        return true;
                    }
                    else
                        return false;
                case enMode.enUpdateUserInfoMode:
                    if (_UpdateUser())
                        return true;
                    else
                        return false;
            }

            return false;
        }

        public static bool IsUserExists(int UserID)
        {
            return clsDataAccessUser.IsUserExists(UserID);
        }

        public static bool IsUserExists(string UserName)
        {
            return clsDataAccessUser.IsUserExists(UserName);
        }

        public static bool IsUserExistsByPersonID(int PersonID)
        {
            return clsDataAccessUser.IsUserExistsByPersonID(PersonID);
        }

    }
}
