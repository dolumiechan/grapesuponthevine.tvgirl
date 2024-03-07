using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp7
{
    internal class Program
    {
        static void Main()
        {
        }
    }
}
public interface IDamageable
{
    int health { get; set; }
    void TakeDamage(int damage);
    void Die();
}
public class Player : IDamageable
{
    public int health { get; set; }

    public Player(int health)
    {
        this.health = health;
    }
    public void Die()
    {
        Console.WriteLine("Игрок бомбом");
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }
}
public class Wall : IDamageable
{
    public int health { get; set; }

    public Wall(int health)
    {
        this.health = health;
    }
    public void Die()
    {
        Console.WriteLine("Стена пупупу");
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }
}
public class Car : IDamageable
{
    public int health { get; set; }

    public Car(int health)
    {
        this.health = health;
    }    
    public void Die()
    {
        Console.WriteLine("Машина бумбум");
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }
}


