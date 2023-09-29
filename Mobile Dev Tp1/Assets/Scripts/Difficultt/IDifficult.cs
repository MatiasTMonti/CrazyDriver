using UnityEngine;

public interface IDifficult
{
    void ConfigureObjects(GameObject[] gameObjects);
}

public class EasyDifficultyStrategy : IDifficult
{
    public void ConfigureObjects(GameObject[] gameObjects)
    {
        foreach (var obj in gameObjects)
        {
            obj.SetActive(true);
        }

        if (gameObjects.Length > 0)
        {
            // Supongamos que desactivamos el primer objeto en el arreglo
            gameObjects[0].SetActive(false);
            gameObjects[1].SetActive(false);
        }
    }
}

public class NormalDifficultyStrategy : IDifficult
{
    public void ConfigureObjects(GameObject[] gameObjects)
    {
        foreach (var obj in gameObjects)
        {
            // Configura objetos para el nivel normal
            obj.SetActive(true);
        }

        if (gameObjects.Length > 0)
        {
            // Supongamos que desactivamos el primer objeto en el arreglo
            gameObjects[1].SetActive(false);
            gameObjects[2].SetActive(false);
            gameObjects[5].SetActive(false);
            gameObjects[8].SetActive(false);
        }
    }
}

public class HardDifficultyStrategy : IDifficult
{
    public void ConfigureObjects(GameObject[] gameObjects)
    {
        foreach (var obj in gameObjects)
        {
            // Configura objetos para el nivel difícil
            obj.SetActive(true);
        }

        if (gameObjects.Length > 0)
        {
            // Supongamos que desactivamos el primer objeto en el arreglo
            gameObjects[2].SetActive(false);
            gameObjects[3].SetActive(false);
            gameObjects[5].SetActive(false);
            gameObjects[6].SetActive(false);
            gameObjects[8].SetActive(false);
            gameObjects[9].SetActive(false);
        }
    }
}
