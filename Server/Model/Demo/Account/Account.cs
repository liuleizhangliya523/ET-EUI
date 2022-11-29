namespace ET
{
    public enum AccountType
    {
        General = 0,
        BlackList = 1
    }

    public class Account: Entity, IAwake
    {
        public string AccountName; //用户名
        public string Password; //密码
        public long CreateTime; //创建时间
        public int AccountType; //账号类型
    }
}