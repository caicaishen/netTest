using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace mvc3_Proj
{
    public class UserStore
    {
        string _filePath = "D:\\vs.Test.Mine\\test_Proj\\mvc3_Proj";
        public UserStore(string ss) {
            _filePath = ss;
        }
        
        // 创建用户
        public async Task CreateAsync(IdentityUser user)
        {

            user.Id = Guid.NewGuid().ToString();
            using (var stream = new System.IO.StreamWriter(_filePath, true, Encoding.UTF8))
            {
                await stream.WriteLineAsync(user.ToString());
            }
        }

        // 根据用户名找用户
        public async Task<IdentityUser> FindByNameAsync(string userName)
        {
            using (var stream = new System.IO.StreamReader(_filePath))
            {
                string line;
                IdentityUser result = null;
                while ((line = await stream.ReadLineAsync()) != null)
                {
                    var user = IdentityUser.FromString(line);
                    if (user.UserName == userName)
                    {
                        result = user;
                        break;
                    }
                }
                return result;
            }
        }
    }
}