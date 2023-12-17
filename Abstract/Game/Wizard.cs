using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses.Game;

public abstract class Character
{
    public int level;
    public string name;

    public abstract void Move();
    public abstract void Attack();
    public abstract void UseAbility();


}