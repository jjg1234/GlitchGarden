using UnityEngine;
using UnityEditor;
using NUnit.Framework;

public class MainEditorTest {

	[Test]
	public void EditorTest() {
		//Arrange
		var gameObject = new GameObject();

		//Act
		//Try to rename the GameObject
		var newGameObjectName = "My game object";
		gameObject.name = newGameObjectName;

		//Assert
		//The object has a new name
		Assert.AreEqual(newGameObjectName, gameObject.name);
	}

	[Test]
	public void StarDisplayUpdateTest()
	{
		//Arrange
		var gameObject = new GameObject();

		//Act
		//Try to rename the GameObject
		var newGameObjectName = "StarDisplay";
		gameObject.name = newGameObjectName;
		gameObject.AddComponent<UnityEngine.UI.Text>();
		gameObject.AddComponent<StarDisplay>();

		StarDisplay myStarDisplay = GameObject.FindObjectOfType<StarDisplay>();
		myStarDisplay.Initialize();
		int startStars = myStarDisplay.GetStars();

		myStarDisplay.AddStars(10);

		Assert.AreEqual((startStars + 10).ToString(), myStarDisplay.GetStarsDisplay());
	}

}
