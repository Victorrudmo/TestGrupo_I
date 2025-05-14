using NUnit.Framework;
using UnityEngine;

[TestFixture]
public class PlayerTests
{
    private Player player;

    // Este método se ejecuta antes de cada prueba.
    [SetUp]
    public void Setup()
    {
        // Crear un objeto vacío y añadir el script Player
        GameObject playerObject = new GameObject();
        player = playerObject.AddComponent<Player>();
    }

    // Prueba para comprobar que la salud inicial es 100
    [Test]
    public void PlayerHealthStartsAt100()
    {
        Assert.AreEqual(100, player.health);
    }

    // Prueba para comprobar que el jugador recibe daño correctamente
    [Test]
    public void PlayerTakesDamageCorrectly()
    {
        player.TakeDamage(30);
        Assert.AreEqual(70, player.health);
    }

    // Prueba para comprobar que la salud no baja de 0
    [Test]
    public void PlayerHealthDoesNotGoBelowZero()
    {
        player.TakeDamage(150); // Recibe daño mayor que su salud
        Assert.AreEqual(0, player.health);
    }

    // Prueba para comprobar que el jugador se cura correctamente
    [Test]
    public void PlayerHealsCorrectly()
    {
        player.TakeDamage(30); // Baja la salud
        player.Heal(20); // Cura 20 de salud
        Assert.AreEqual(90, player.health);
    }

    // Prueba para comprobar que la salud no sube de 100
    [Test]
    public void PlayerHealthDoesNotExceed100()
    {
        player.Heal(20); // Cura al jugador, pero su salud ya es 100
        Assert.AreEqual(100, player.health);
    }

    // Este método se ejecuta después de cada prueba.
    [TearDown]
    public void TearDown()
    {
        // Limpiar el objeto del jugador si es necesario
        Object.Destroy(player.gameObject);
    }
}
