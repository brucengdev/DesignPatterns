namespace Mediator;
using Shouldly;

public class MediatorTests
{
    [Fact]
    public void TestDishSelection()
    {
        var dialog = new DishSelectionDialog();

        dialog.DishSelector.SetSelection("Pho");
        dialog.DishSelector.ValueText.ShouldBe("Pho");

        dialog.IncludeUtensils.Enabled.ShouldBeTrue();

        dialog.NoodleOptionsSelector.Enabled.ShouldBeTrue();

        dialog.DishSelector.SetSelection("Burger");
        dialog.DishSelector.ValueText.ShouldBe("Burger");

        dialog.IncludeUtensils.Enabled.ShouldBeFalse();//no need for utensils to eat burgers
        dialog.NoodleOptionsSelector.Enabled.ShouldBeFalse();

        dialog.DishSelector.SetSelection("Pho");
        dialog.DishSelector.ValueText.ShouldBe("Pho");
        dialog.IncludeUtensils.Enabled.ShouldBeTrue();
        dialog.NoodleOptionsSelector.Enabled.ShouldBeTrue();
        
        dialog.DishSelector.SetSelection("Soup");
        dialog.DishSelector.ValueText.ShouldBe("Soup");
        dialog.IncludeUtensils.Enabled.ShouldBeTrue();
        dialog.NoodleOptionsSelector.Enabled.ShouldBeFalse();
        
        dialog.DishSelector.SetSelection("Pizza");
        dialog.DishSelector.ValueText.ShouldBe("Pizza");
        dialog.IncludeUtensils.Enabled.ShouldBeFalse();
        dialog.NoodleOptionsSelector.Enabled.ShouldBeFalse();
    }
}