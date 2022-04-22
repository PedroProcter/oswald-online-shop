public class UserAccountService{
   private List<UserAccount> _users; 

public UserAccountService(){


    _users = new List<UserAccount>{
        new UserAccount{UserName = "user", Password = "user", Role = "user"}
    };
    
}

public UserAccount? GetByUserName(string userName){
    return _users.FirstOrDefault(u => u.UserName == userName);
}

}