using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Server.MirDatabase;

namespace Server
{
    class SQLDataHandler
    {
        static private readonly string ConnectionString = "server=localhost;user=m2_encore;database=m2;port=4400;password=8hKl5_DS!";

        static MySqlConnection conn = new MySqlConnection(ConnectionString);
        static MySqlCommand cmd;
        static MySqlDataReader reader;

        public static void InsertMapInfo(MapInfo mapInfo)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("InsertMapInfo", conn) { CommandType = CommandType.StoredProcedure };

                cmd.Parameters.AddWithValue("MapIndex", mapInfo.Index);
                cmd.Parameters.AddWithValue("FileName", mapInfo.FileName);
                cmd.Parameters.AddWithValue("Title", mapInfo.Title);
                cmd.Parameters.AddWithValue("MiniMap", (int)mapInfo.MiniMap);
                cmd.Parameters.AddWithValue("Light", (byte)mapInfo.Light);
                cmd.Parameters.AddWithValue("BigMap", (int)mapInfo.BigMap);
                cmd.Parameters.AddWithValue("SafeZoneCount", mapInfo.SafeZones.Count);
                cmd.Parameters.AddWithValue("RespawnsCount", mapInfo.Respawns.Count);
                cmd.Parameters.AddWithValue("NPCCount", mapInfo.NPCs.Count);
                cmd.Parameters.AddWithValue("MovementsCount", mapInfo.Movements.Count);
                cmd.Parameters.AddWithValue("NoTeleport", (byte)(mapInfo.NoTeleport ? 1 : 0));
                cmd.Parameters.AddWithValue("NoReconnect", (byte)(mapInfo.NoReconnect ? 1 : 0));
                cmd.Parameters.AddWithValue("NoReconnectMap", mapInfo.NoReconnectMap);
                cmd.Parameters.AddWithValue("NoRandom", (byte)(mapInfo.NoRandom ? 1 : 0));
                cmd.Parameters.AddWithValue("NoEscape", (byte)(mapInfo.NoEscape ? 1 : 0));
                cmd.Parameters.AddWithValue("NoRecall", (byte)(mapInfo.NoRecall ? 1 : 0));
                cmd.Parameters.AddWithValue("NoDrug", (byte)(mapInfo.NoDrug ? 1 : 0));
                cmd.Parameters.AddWithValue("NoPosition", (byte)(mapInfo.NoPosition ? 1 : 0));
                cmd.Parameters.AddWithValue("NoThrowItem", (byte)(mapInfo.NoThrowItem ? 1 : 0));
                cmd.Parameters.AddWithValue("NoDropPlayer", (byte)(mapInfo.NoDropPlayer ? 1 : 0));
                cmd.Parameters.AddWithValue("NoDropMonster", (byte)(mapInfo.NoDropMonster ? 1 : 0));
                cmd.Parameters.AddWithValue("NoNames", (byte)(mapInfo.NoNames ? 1 : 0));
                cmd.Parameters.AddWithValue("Fight", (byte)(mapInfo.Fight ? 1 : 0));
                cmd.Parameters.AddWithValue("NeedHole", (byte)(mapInfo.NeedHole ? 1 : 0));
                cmd.Parameters.AddWithValue("Fire", (byte)(mapInfo.Fire ? 1 : 0));
                cmd.Parameters.AddWithValue("FireDamage", mapInfo.FireDamage);
                cmd.Parameters.AddWithValue("Lightning", (byte)(mapInfo.Lightning ? 1 : 0));
                cmd.Parameters.AddWithValue("LightningDamage", mapInfo.LightningDamage);
                cmd.Parameters.AddWithValue("MapDarkLight", mapInfo.MapDarkLight);
                cmd.Parameters.AddWithValue("MineZoneCount", mapInfo.MineZones.Count);
                cmd.Parameters.AddWithValue("MineIndex", (byte)mapInfo.MineIndex);
                cmd.Parameters.AddWithValue("NoMount", (byte)(mapInfo.NoMount ? 1 : 0));
                cmd.Parameters.AddWithValue("NeedBridle", (byte)(mapInfo.NeedBridle ? 1 : 0));
                cmd.Parameters.AddWithValue("NoFight", (byte)(mapInfo.NoFight ? 1 : 0));
                cmd.Parameters.AddWithValue("Music", (int)mapInfo.Music);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            { }
            finally
            {
                conn.Close();
            }
        }


        public static void InsertItemInfo(ItemInfo itemInfo)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("InsertItemInfo", conn) { CommandType = CommandType.StoredProcedure };

                cmd.Parameters.AddWithValue("ItemIndex", itemInfo.Index);
                cmd.Parameters.AddWithValue("ItemName", itemInfo.Name);
                cmd.Parameters.AddWithValue("ItemType", (short)itemInfo.Type);
                cmd.Parameters.AddWithValue("ItemGrade", (short)itemInfo.Grade);
                cmd.Parameters.AddWithValue("RequiredType", (short)itemInfo.RequiredType);
                cmd.Parameters.AddWithValue("RequiredClass", (short)itemInfo.RequiredClass);
                cmd.Parameters.AddWithValue("RequiredGender", (short)itemInfo.RequiredGender);
                cmd.Parameters.AddWithValue("SetIndex", (short)itemInfo.Set);
                cmd.Parameters.AddWithValue("Shape", itemInfo.Shape);
                cmd.Parameters.AddWithValue("Weight", itemInfo.Weight);
                cmd.Parameters.AddWithValue("Light", itemInfo.Light);
                cmd.Parameters.AddWithValue("RequiredAmount", itemInfo.RequiredAmount);
                cmd.Parameters.AddWithValue("Image", itemInfo.Image);
                cmd.Parameters.AddWithValue("Durability", itemInfo.Durability);
                cmd.Parameters.AddWithValue("StackSize", itemInfo.StackSize);
                cmd.Parameters.AddWithValue("Price", itemInfo.Price);
                cmd.Parameters.AddWithValue("MinAC", itemInfo.MinAC);
                cmd.Parameters.AddWithValue("MaxAC", itemInfo.MaxAC);
                cmd.Parameters.AddWithValue("MinMAC", itemInfo.MinMAC);
                cmd.Parameters.AddWithValue("MaxMAC", itemInfo.MaxMAC);
                cmd.Parameters.AddWithValue("MinDC", itemInfo.MinDC);
                cmd.Parameters.AddWithValue("MaxDC", itemInfo.MaxDC);
                cmd.Parameters.AddWithValue("MinMC", itemInfo.MinMC);
                cmd.Parameters.AddWithValue("MaxMC", itemInfo.MaxMC);
                cmd.Parameters.AddWithValue("MinSC", itemInfo.MinSC);
                cmd.Parameters.AddWithValue("MaxSC", itemInfo.MaxSC);
                cmd.Parameters.AddWithValue("HP", itemInfo.HP);
                cmd.Parameters.AddWithValue("MP", itemInfo.MP);
                cmd.Parameters.AddWithValue("Accuracy", itemInfo.Accuracy);
                cmd.Parameters.AddWithValue("Agility", itemInfo.Agility);
                cmd.Parameters.AddWithValue("Luck", itemInfo.Luck);
                cmd.Parameters.AddWithValue("AttackSpeed", itemInfo.AttackSpeed);
                cmd.Parameters.AddWithValue("StartItem", itemInfo.StartItem ? 1 : 0);
                cmd.Parameters.AddWithValue("BagWeight", itemInfo.BagWeight);
                cmd.Parameters.AddWithValue("HandWeight", itemInfo.HandWeight);
                cmd.Parameters.AddWithValue("WearWeight", itemInfo.WearWeight);
                cmd.Parameters.AddWithValue("Effect", itemInfo.Effect);
                cmd.Parameters.AddWithValue("Strong", itemInfo.Strong);
                cmd.Parameters.AddWithValue("MagicResist", itemInfo.MagicResist);
                cmd.Parameters.AddWithValue("PoisonResist", itemInfo.PoisonResist);
                cmd.Parameters.AddWithValue("HealthRecovery", itemInfo.HealthRecovery);
                cmd.Parameters.AddWithValue("SpellRecovery", itemInfo.SpellRecovery);
                cmd.Parameters.AddWithValue("PoisonRecovery", itemInfo.PoisonRecovery);
                cmd.Parameters.AddWithValue("HPRate", itemInfo.HPrate);
                cmd.Parameters.AddWithValue("MPRate", itemInfo.MPrate);
                cmd.Parameters.AddWithValue("CriticalRate", itemInfo.CriticalRate);
                cmd.Parameters.AddWithValue("CriticalDamage", itemInfo.CriticalDamage);
                cmd.Parameters.AddWithValue("bools", itemInfo.bools);
                cmd.Parameters.AddWithValue("NeedIdentify", itemInfo.NeedIdentify ? 1 : 0);
                cmd.Parameters.AddWithValue("ShowGroupPickup", itemInfo.ShowGroupPickup ? 1 : 0);
                cmd.Parameters.AddWithValue("ClassBased", itemInfo.ClassBased ? 1 : 0);
                cmd.Parameters.AddWithValue("LevelBased", itemInfo.LevelBased ? 1 : 0);
                cmd.Parameters.AddWithValue("CanMine", itemInfo.CanMine ? 1 : 0);
                cmd.Parameters.AddWithValue("GlobalDropNotify", itemInfo.GlobalDropNotify ? 1 : 0);
                cmd.Parameters.AddWithValue("MaxACRate", itemInfo.MaxAcRate);
                cmd.Parameters.AddWithValue("MaxMACRate", itemInfo.MaxMacRate);
                cmd.Parameters.AddWithValue("Holy", itemInfo.Holy);
                cmd.Parameters.AddWithValue("Freezing", itemInfo.Freezing);
                cmd.Parameters.AddWithValue("PoisonAttack", itemInfo.PoisonAttack);
                cmd.Parameters.AddWithValue("BindMode", (short)itemInfo.Bind);
                cmd.Parameters.AddWithValue("Reflect", itemInfo.Reflect);
                cmd.Parameters.AddWithValue("HPDrainRate", itemInfo.HpDrainRate);
                cmd.Parameters.AddWithValue("UniqueType", (short)itemInfo.Unique);
                cmd.Parameters.AddWithValue("RandomStatsID", itemInfo.RandomStatsId);
                cmd.Parameters.AddWithValue("CanFastRun", itemInfo.CanFastRun ? 1 : 0);
                cmd.Parameters.AddWithValue("CanAwakening", itemInfo.CanAwakening ? 1 : 0);
                cmd.Parameters.AddWithValue("IsToolTip", itemInfo.ToolTip != "" ? 1 : 0);
                cmd.Parameters.AddWithValue("ToolTip", itemInfo.ToolTip);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            { }
            finally
            {
                conn.Close();
            }
        }


        public static void InsertMonsterInfo(MonsterInfo monsterInfo)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("InsertMonsterInfo", conn) { CommandType = CommandType.StoredProcedure };

                cmd.Parameters.AddWithValue("MonsterIndex", monsterInfo.Index);
                cmd.Parameters.AddWithValue("MonsterName", monsterInfo.Name);
                cmd.Parameters.AddWithValue("Image", (short)monsterInfo.Image);
                cmd.Parameters.AddWithValue("AI", monsterInfo.AI);
                cmd.Parameters.AddWithValue("Effect", monsterInfo.Effect);
                cmd.Parameters.AddWithValue("MonsterLevel", monsterInfo.Level);
                cmd.Parameters.AddWithValue("ViewRange", monsterInfo.ViewRange);
                cmd.Parameters.AddWithValue("CoolEye", monsterInfo.CoolEye);
                cmd.Parameters.AddWithValue("HP", monsterInfo.HP);
                cmd.Parameters.AddWithValue("MinAC", monsterInfo.MinAC);
                cmd.Parameters.AddWithValue("MaxAC", monsterInfo.MaxAC);
                cmd.Parameters.AddWithValue("MinMAC", monsterInfo.MinMAC);
                cmd.Parameters.AddWithValue("MaxMAC", monsterInfo.MaxMAC);
                cmd.Parameters.AddWithValue("MinDC", monsterInfo.MinDC);
                cmd.Parameters.AddWithValue("MaxDC", monsterInfo.MaxDC);
                cmd.Parameters.AddWithValue("MinMC", monsterInfo.MinMC);
                cmd.Parameters.AddWithValue("MaxMC", monsterInfo.MaxMC);
                cmd.Parameters.AddWithValue("MinSC", monsterInfo.MinSC);
                cmd.Parameters.AddWithValue("MaxSC", monsterInfo.MaxSC);
                cmd.Parameters.AddWithValue("Accuracy", monsterInfo.Accuracy);
                cmd.Parameters.AddWithValue("Agility", monsterInfo.Agility);
                cmd.Parameters.AddWithValue("Light", monsterInfo.Light);
                cmd.Parameters.AddWithValue("AttackSpeed", monsterInfo.AttackSpeed);
                cmd.Parameters.AddWithValue("MoveSpeed", monsterInfo.MoveSpeed);
                cmd.Parameters.AddWithValue("Experience", monsterInfo.Experience);
                cmd.Parameters.AddWithValue("CanPush", monsterInfo.CanPush ? 1 : 0);
                cmd.Parameters.AddWithValue("CanTame", monsterInfo.CanTame ? 1 : 0);
                cmd.Parameters.AddWithValue("AutoRev", monsterInfo.AutoRev ? 1 : 0);
                cmd.Parameters.AddWithValue("Undead", monsterInfo.Undead ? 1 : 0);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            { }
            finally
            {
                conn.Close();
            }
        }

        public static void InsertNPCInfo(NPCInfo npcInfo)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("InsertNPCInfo", conn) { CommandType = CommandType.StoredProcedure };

                cmd.Parameters.AddWithValue("NPCIndex", npcInfo.Index);
                cmd.Parameters.AddWithValue("MapIndex", npcInfo.MapIndex);
                cmd.Parameters.AddWithValue("FileName", npcInfo.FileName);
                cmd.Parameters.AddWithValue("NPCName", npcInfo.Name);
                cmd.Parameters.AddWithValue("Location_X", npcInfo.Location.X);
                cmd.Parameters.AddWithValue("Location_Y", npcInfo.Location.Y);
                cmd.Parameters.AddWithValue("Image", npcInfo.Image);
                cmd.Parameters.AddWithValue("Rate", npcInfo.Rate);
                cmd.Parameters.AddWithValue("TimeVisible", npcInfo.TimeVisible ? 1 : 0);
                cmd.Parameters.AddWithValue("HourStart", npcInfo.HourStart);
                cmd.Parameters.AddWithValue("MinuteStart", npcInfo.MinuteStart);
                cmd.Parameters.AddWithValue("HourEnd", npcInfo.HourEnd);
                cmd.Parameters.AddWithValue("MinuteEnd", npcInfo.MinuteEnd);
                cmd.Parameters.AddWithValue("MinLev", npcInfo.MinLev);
                cmd.Parameters.AddWithValue("MaxLev", npcInfo.MaxLev);
                cmd.Parameters.AddWithValue("DayofWeek", npcInfo.DayofWeek);
                cmd.Parameters.AddWithValue("ClassRequired", npcInfo.ClassRequired);
                cmd.Parameters.AddWithValue("Conquest", npcInfo.Conquest);
                cmd.Parameters.AddWithValue("FlagNeeded", npcInfo.FlagNeeded);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            { }
            finally
            {
                conn.Close();
            }
        }


        public static void InsertQuestInfo(QuestInfo questInfo)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("InsertQuestInfo", conn) { CommandType = CommandType.StoredProcedure };

                cmd.Parameters.AddWithValue("QuestIndex", questInfo.Index);
                cmd.Parameters.AddWithValue("NPCIndex", questInfo.NpcIndex <= 0 ? 0 : questInfo.NpcIndex);
                cmd.Parameters.AddWithValue("QuestName", questInfo.Name);
                cmd.Parameters.AddWithValue("QuestGroup", questInfo.Group);
                cmd.Parameters.AddWithValue("FileName", questInfo.FileName);
                cmd.Parameters.AddWithValue("RequiredMinLevel", questInfo.RequiredMinLevel);
                cmd.Parameters.AddWithValue("RequiredMaxLevel", questInfo.RequiredMaxLevel);
                cmd.Parameters.AddWithValue("RequiredQuest", questInfo.RequiredQuest);
                cmd.Parameters.AddWithValue("RequiredClass", (short)questInfo.RequiredClass);
                cmd.Parameters.AddWithValue("QuestType", (short)questInfo.Type);
                cmd.Parameters.AddWithValue("GotoMessage", questInfo.GotoMessage);
                cmd.Parameters.AddWithValue("KillMessage", questInfo.KillMessage);
                cmd.Parameters.AddWithValue("ItemMessage", questInfo.ItemMessage);
                cmd.Parameters.AddWithValue("FlagMessage", questInfo.FlagMessage);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            { }
            finally
            {
                conn.Close();
            }
        }


        public static void InsertDragonInfo(DragonInfo dragonInfo)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("InsertDragonInfo", conn) { CommandType = CommandType.StoredProcedure };

                cmd.Parameters.AddWithValue("Enabled", dragonInfo.Enabled ? 1 : 0);
                cmd.Parameters.AddWithValue("MapFileName", dragonInfo.MapFileName);
                cmd.Parameters.AddWithValue("MonsterName", dragonInfo.MonsterName);
                cmd.Parameters.AddWithValue("BodyName", dragonInfo.BodyName);
                cmd.Parameters.AddWithValue("Location_X", dragonInfo.Location.X);
                cmd.Parameters.AddWithValue("Location_Y", dragonInfo.Location.Y);
                cmd.Parameters.AddWithValue("DropAreaTop_X", dragonInfo.DropAreaTop.X);
                cmd.Parameters.AddWithValue("DropAreaTop_Y", dragonInfo.DropAreaTop.Y);
                cmd.Parameters.AddWithValue("DropAreaBottom_X", dragonInfo.DropAreaBottom.X);
                cmd.Parameters.AddWithValue("DropAreaBottom_Y", dragonInfo.DropAreaBottom.Y);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            { }
            finally
            {
                conn.Close();
            }
        }


        public static void InsertMagicInfo(MagicInfo magicInfo)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("InsertMagicInfo", conn) { CommandType = CommandType.StoredProcedure };

                cmd.Parameters.AddWithValue("SpellName", magicInfo.Name);
                cmd.Parameters.AddWithValue("Spell", (short)magicInfo.Spell);
                cmd.Parameters.AddWithValue("BaseCost", magicInfo.BaseCost);
                cmd.Parameters.AddWithValue("LevelCost", magicInfo.LevelCost);
                cmd.Parameters.AddWithValue("Icon", magicInfo.Icon);
                cmd.Parameters.AddWithValue("Level1", magicInfo.Level1);
                cmd.Parameters.AddWithValue("Level2", magicInfo.Level2);
                cmd.Parameters.AddWithValue("Level3", magicInfo.Level3);
                cmd.Parameters.AddWithValue("Need1", magicInfo.Need1);
                cmd.Parameters.AddWithValue("Need2", magicInfo.Need2);
                cmd.Parameters.AddWithValue("Need3", magicInfo.Need3);
                cmd.Parameters.AddWithValue("DelayBase", magicInfo.DelayBase);
                cmd.Parameters.AddWithValue("DelayReduction", magicInfo.DelayReduction);
                cmd.Parameters.AddWithValue("PowerBase", magicInfo.PowerBase);
                cmd.Parameters.AddWithValue("PowerBonus", magicInfo.PowerBonus);
                cmd.Parameters.AddWithValue("MPowerBase", magicInfo.MPowerBase);
                cmd.Parameters.AddWithValue("MPowerBonus", magicInfo.MPowerBonus);
                cmd.Parameters.AddWithValue("MagicRange", magicInfo.Range);
                cmd.Parameters.AddWithValue("MultiplierBase", magicInfo.MultiplierBase);
                cmd.Parameters.AddWithValue("MultiplierBonus", magicInfo.MultiplierBonus);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            { }
            finally
            {
                conn.Close();
            }
        }


        public static void InsertGameShopItem(GameShopItem gameShopItem)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("InsertGameShopItem", conn) { CommandType = CommandType.StoredProcedure };

                cmd.Parameters.AddWithValue("ItemIndex", gameShopItem.ItemIndex);
                cmd.Parameters.AddWithValue("GIndex", gameShopItem.GIndex);
                cmd.Parameters.AddWithValue("GoldPrice", gameShopItem.GoldPrice);
                cmd.Parameters.AddWithValue("CreditPrice", gameShopItem.CreditPrice);
                cmd.Parameters.AddWithValue("ItemCount", gameShopItem.Count);
                cmd.Parameters.AddWithValue("Class", gameShopItem.Class);
                cmd.Parameters.AddWithValue("Category", gameShopItem.Category);
                cmd.Parameters.AddWithValue("Stock", gameShopItem.Stock);
                cmd.Parameters.AddWithValue("iStock", gameShopItem.iStock ? 1 : 0);
                cmd.Parameters.AddWithValue("Deal", gameShopItem.Deal ? 1 : 0);
                cmd.Parameters.AddWithValue("TopItem", gameShopItem.TopItem ? 1 : 0);
                cmd.Parameters.AddWithValue("ItemDate", gameShopItem.Date);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            { }
            finally
            {
                conn.Close();
            }
        }

        public static void InsertConquestInfo(ConquestInfo conquestInfo)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("InsertConquestInfo", conn) { CommandType = CommandType.StoredProcedure };

                cmd.Parameters.AddWithValue("ConquestIndex", conquestInfo.Index);
                cmd.Parameters.AddWithValue("FullMap", conquestInfo.FullMap ? 1 : 0);
                cmd.Parameters.AddWithValue("Location_X", conquestInfo.Location.X);
                cmd.Parameters.AddWithValue("Location_Y", conquestInfo.Location.Y);
                cmd.Parameters.AddWithValue("ConquestSize", conquestInfo.Size);
                cmd.Parameters.AddWithValue("ConquestName", conquestInfo.Name);
                cmd.Parameters.AddWithValue("MapIndex", conquestInfo.MapIndex);
                cmd.Parameters.AddWithValue("PalaceIndex", conquestInfo.PalaceIndex);
                cmd.Parameters.AddWithValue("GuardIndex", conquestInfo.GuardIndex);
                cmd.Parameters.AddWithValue("GateIndex", conquestInfo.GateIndex);
                cmd.Parameters.AddWithValue("WallIndex", conquestInfo.WallIndex);
                cmd.Parameters.AddWithValue("SiegeIndex", conquestInfo.SiegeIndex);
                cmd.Parameters.AddWithValue("FlagIndex", conquestInfo.FlagIndex);
                cmd.Parameters.AddWithValue("StartHour", conquestInfo.StartHour);
                cmd.Parameters.AddWithValue("WarLength", conquestInfo.WarLength);
                cmd.Parameters.AddWithValue("WarType", (short)conquestInfo.Type);
                cmd.Parameters.AddWithValue("WarGame", (short)conquestInfo.Game);
                cmd.Parameters.AddWithValue("Monday", conquestInfo.Monday ? 1 : 0);
                cmd.Parameters.AddWithValue("Tuesday", conquestInfo.Tuesday ? 1 : 0);
                cmd.Parameters.AddWithValue("Wednesday", conquestInfo.Wednesday ? 1 : 0);
                cmd.Parameters.AddWithValue("Thursday", conquestInfo.Thursday ? 1 : 0);
                cmd.Parameters.AddWithValue("Friday", conquestInfo.Friday ? 1 : 0);
                cmd.Parameters.AddWithValue("Saturday", conquestInfo.Saturday ? 1 : 0);
                cmd.Parameters.AddWithValue("Sunday", conquestInfo.Sunday ? 1 : 0);
                cmd.Parameters.AddWithValue("KingLocation_X", conquestInfo.KingLocation.X);
                cmd.Parameters.AddWithValue("KingLocation_Y", conquestInfo.KingLocation.Y);
                cmd.Parameters.AddWithValue("KingSize", conquestInfo.KingSize);
                cmd.Parameters.AddWithValue("ControlPointIndex", conquestInfo.ControlPointIndex);
                cmd.Parameters.AddWithValue("ControlPointCount", conquestInfo.ControlPoints.Count);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            { }
            finally
            {
                conn.Close();
            }
        }


        public static void InsertConquestArcherInfo(ConquestArcherInfo conquestArcherInfo, int conquestIndex)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("InsertConquestArcherInfo", conn) { CommandType = CommandType.StoredProcedure };

                cmd.Parameters.AddWithValue("ArcherIndex", conquestArcherInfo.Index);
                cmd.Parameters.AddWithValue("ConquestIndex", conquestIndex);
                cmd.Parameters.AddWithValue("Location_X", conquestArcherInfo.Location.X);
                cmd.Parameters.AddWithValue("Location_Y", conquestArcherInfo.Location.Y);
                cmd.Parameters.AddWithValue("MobIndex", conquestArcherInfo.MobIndex);
                cmd.Parameters.AddWithValue("ArcherName", conquestArcherInfo.Name);
                cmd.Parameters.AddWithValue("RepairCost", conquestArcherInfo.RepairCost);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            { }
            finally
            {
                conn.Close();
            }
        }


        public static void InsertConquestGateInfo(ConquestGateInfo conquestGateInfo, int conquestIndex)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("InsertConquestGateInfo", conn) { CommandType = CommandType.StoredProcedure };

                cmd.Parameters.AddWithValue("GateIndex", conquestGateInfo.Index);
                cmd.Parameters.AddWithValue("ConquestIndex", conquestIndex);
                cmd.Parameters.AddWithValue("Location_X", conquestGateInfo.Location.X);
                cmd.Parameters.AddWithValue("Location_Y", conquestGateInfo.Location.Y);
                cmd.Parameters.AddWithValue("MobIndex", conquestGateInfo.MobIndex);
                cmd.Parameters.AddWithValue("GateName", conquestGateInfo.Name);
                cmd.Parameters.AddWithValue("RepairCost", conquestGateInfo.RepairCost);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            { }
            finally
            {
                conn.Close();
            }
        }


        public static void InsertConquestWallInfo(ConquestWallInfo conquestWallInfo, int conquestIndex)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("InsertConquestWallInfo", conn) { CommandType = CommandType.StoredProcedure };

                cmd.Parameters.AddWithValue("WallIndex", conquestWallInfo.Index);
                cmd.Parameters.AddWithValue("WallConquestIndex", conquestIndex);
                cmd.Parameters.AddWithValue("Location_X", conquestWallInfo.Location.X);
                cmd.Parameters.AddWithValue("Location_Y", conquestWallInfo.Location.Y);
                cmd.Parameters.AddWithValue("MobIndex", conquestWallInfo.MobIndex);
                cmd.Parameters.AddWithValue("WallName", conquestWallInfo.Name);
                cmd.Parameters.AddWithValue("RepairCost", conquestWallInfo.RepairCost);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            { }
            finally
            {
                conn.Close();
            }
        }


        public static void InsertConquestSiegeInfo(ConquestSiegeInfo conquestSiegeInfo, int conquestIndex)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("InsertConquestSiegeInfo", conn) { CommandType = CommandType.StoredProcedure };

                cmd.Parameters.AddWithValue("SiegeIndex", conquestSiegeInfo.Index);
                cmd.Parameters.AddWithValue("SiegeConquestIndex", conquestIndex);
                cmd.Parameters.AddWithValue("Location_X", conquestSiegeInfo.Location.X);
                cmd.Parameters.AddWithValue("Location_Y", conquestSiegeInfo.Location.Y);
                cmd.Parameters.AddWithValue("MobIndex", conquestSiegeInfo.MobIndex);
                cmd.Parameters.AddWithValue("SiegeName", conquestSiegeInfo.Name);
                cmd.Parameters.AddWithValue("RepairCost", conquestSiegeInfo.RepairCost);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            { }
            finally
            {
                conn.Close();
            }
        }


        public static void InsertConquestFlagInfo(ConquestFlagInfo conquestFlagInfo, int conquestIndex)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("InsertConquestFlagInfo", conn) { CommandType = CommandType.StoredProcedure };

                cmd.Parameters.AddWithValue("FlagIndex", conquestFlagInfo.Index);
                cmd.Parameters.AddWithValue("FlagConquestIndex", conquestIndex);
                cmd.Parameters.AddWithValue("Location_X", conquestFlagInfo.Location.X);
                cmd.Parameters.AddWithValue("Location_Y", conquestFlagInfo.Location.Y);
                cmd.Parameters.AddWithValue("FlagName", conquestFlagInfo.Name);
                cmd.Parameters.AddWithValue("FileName", conquestFlagInfo.FileName);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            { }
            finally
            {
                conn.Close();
            }
        }


        public static void InsertConquestControlPointInfo(ConquestFlagInfo conquestFlagInfo, int conquestIndex)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("InsertControlPointInfo", conn) { CommandType = CommandType.StoredProcedure };

                cmd.Parameters.AddWithValue("ControlPointIndex", conquestFlagInfo.Index);
                cmd.Parameters.AddWithValue("ConquestIndex", conquestIndex);
                cmd.Parameters.AddWithValue("Location_X", conquestFlagInfo.Location.X);
                cmd.Parameters.AddWithValue("Location_Y", conquestFlagInfo.Location.Y);
                cmd.Parameters.AddWithValue("ControlPointName", conquestFlagInfo.Name);
                cmd.Parameters.AddWithValue("FileName", conquestFlagInfo.FileName);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            { }
            finally
            {
                conn.Close();
            }
        }


        public static void InsertConquestExtraMapInfo(int conquestIndex, int mapIndex)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("InsertConquestExtraMapInfo", conn) { CommandType = CommandType.StoredProcedure };

                cmd.Parameters.AddWithValue("ConquestIndex", conquestIndex);
                cmd.Parameters.AddWithValue("MapIndex", mapIndex);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            { }
            finally
            {
                conn.Close();
            }
        }


        public static void InsertRespawnInfo(RespawnInfo respawnInfo, int mapIndex)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("InsertRespawnInfo", conn) { CommandType = CommandType.StoredProcedure };

                cmd.Parameters.AddWithValue("MapIndex", mapIndex);
                cmd.Parameters.AddWithValue("MonsterIndex", respawnInfo.MonsterIndex);
                cmd.Parameters.AddWithValue("Location_X", respawnInfo.Location.X);
                cmd.Parameters.AddWithValue("Location_Y", respawnInfo.Location.Y);
                cmd.Parameters.AddWithValue("SpawnCount", respawnInfo.Count);
                cmd.Parameters.AddWithValue("Spread", respawnInfo.Spread);
                cmd.Parameters.AddWithValue("Delay", respawnInfo.Delay);
                cmd.Parameters.AddWithValue("Direction", respawnInfo.Direction);
                cmd.Parameters.AddWithValue("RoutePath", respawnInfo.RoutePath);
                cmd.Parameters.AddWithValue("RandomDelay", respawnInfo.RandomDelay);
                cmd.Parameters.AddWithValue("SaveRespawnDelay", respawnInfo.SaveRespawnTime ? 1 : 0);
                cmd.Parameters.AddWithValue("RespawnTicks", respawnInfo.RespawnTicks);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            { }
            finally
            {
                conn.Close();
            }
        }


        public static List<MapInfo> GetMapInfo()
        {
            List<MapInfo> MapInfoList = new List<MapInfo>();

            try
            {
                conn.Open();

                cmd = new MySqlCommand("GetMapInfo", conn) { CommandType = CommandType.StoredProcedure };

                reader = cmd.ExecuteReader();

                //DataTable dt = new DataTable();
                //dt.Load(reader);

                while (reader.Read())
                    //MapInfoList.Add(new MapInfo(reader));
                    MapInfoList.Add(CreateMapInfo(reader));

                return MapInfoList;
            }
            catch (MySqlException ex)
            {
                MapInfoList = new List<MapInfo>();

                return MapInfoList;
            }
            finally
            {
                if (conn != null)
                    conn.Close();

                if (reader != null)
                    reader.Close();
            }
        }

        private static MapInfo CreateMapInfo(MySqlDataReader reader)
        {
            try
            {
                MapInfo mapInfo = new MapInfo()
                {
                    Index = reader.GetInt32(1),
                    FileName = reader.GetString(2),
                    Title = reader.GetString(3),
                    MiniMap = reader.GetUInt16(4),
                    Light = (LightSetting)reader.GetInt32(5),
                    BigMap = reader.GetUInt16(6),
                    NoTeleport = reader.GetByte(11) == 0 ? true : false,
                    NoReconnect = reader.GetByte(12) == 0 ? true : false,
                    NoReconnectMap = reader.GetString(13),
                    NoRandom = reader.GetByte(14) == 0 ? true : false,
                    NoEscape = reader.GetByte(15) == 0 ? true : false,
                    NoRecall = reader.GetByte(16) == 0 ? true : false,
                    NoDrug = reader.GetByte(17) == 0 ? true : false,
                    NoPosition = reader.GetByte(18) == 0 ? true : false,
                    NoThrowItem = reader.GetByte(19) == 0 ? true : false,
                    NoDropPlayer = reader.GetByte(20) == 0 ? true : false,
                    NoDropMonster = reader.GetByte(21) == 0 ? true : false,
                    NoNames = reader.GetByte(22) == 0 ? true : false,
                    Fight = reader.GetByte(23) == 0 ? true : false,
                    NeedHole = reader.GetByte(24) == 0 ? true : false,
                    Fire = reader.GetByte(25) == 0 ? true : false,
                    FireDamage = reader.GetInt32(26),
                    Lightning = reader.GetByte(27) == 0 ? true : false,
                    LightningDamage = reader.GetInt32(28),
                    MapDarkLight = reader.GetByte(29),
                    MineIndex = reader.GetByte(31),
                    NoMount = reader.GetByte(32) == 0 ? true : false,
                    NeedBridle = reader.GetByte(33) == 0 ? true : false,
                    NoFight = reader.GetByte(34) == 0 ? true : false,
                    Music = (ushort)reader.GetInt32(35)
                };

                return mapInfo;
            }
            catch (Exception ex)
            {
                return new MapInfo();
            }
        }

        public static List<SafeZoneInfo> GetSafeZoneInfo()
        {
            List<SafeZoneInfo> SafeZoneInfoList = new List<SafeZoneInfo>();

            try
            {
                conn.Open();

                cmd = new MySqlCommand("GetSafeZoneInfo", conn) { CommandType = CommandType.StoredProcedure };

                reader = cmd.ExecuteReader();

                return SafeZoneInfoList;
            }
            catch (MySqlException ex)
            {
                SafeZoneInfoList = new List<SafeZoneInfo>();

                return SafeZoneInfoList;
            }
            finally
            {
                if (conn != null)
                    conn.Close();

                if (reader != null)
                    reader.Close();
            }
        }
    }
}
