When I  run git push,  I keep see the below error:<br/>

<img width="683" alt="image" src="https://github.com/zhangguanghuib/UnifyPortalDev/assets/14832260/0261b202-d742-4c8b-9624-80652277dfcb">

The resolution is:
![image](https://github.com/zhangguanghuib/UnifyPortalDev/assets/14832260/01e3caab-8822-45b2-8f4d-2a26c1cb4f45)

```
git credential-cache exit
control /name Microsoft.CredentialManager
```

On the opened dialog,  remove or github related

