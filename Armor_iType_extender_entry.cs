using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using EFT.InventoryLogic;

namespace backpack_insert
{
   [BepInPlugin("Armor_iType_extender", "Armor iType extender", "1.0.1")]
    public class Armor_iType_extender_entry : BaseUnityPlugin
    {private void Awake()
        {
            {
                var bindingFlags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public;
                var field = typeof(Inventory).GetField("ArmorSlots", bindingFlags);

                field.SetValue(null, new EquipmentSlot[]
                {
                EquipmentSlot.Backpack,
                EquipmentSlot.TacticalVest,
                EquipmentSlot.ArmorVest,
                EquipmentSlot.Headwear,
                EquipmentSlot.FaceCover,
                EquipmentSlot.Eyewear,
                EquipmentSlot.ArmBand,               
                });
            }

        }
    }
}
