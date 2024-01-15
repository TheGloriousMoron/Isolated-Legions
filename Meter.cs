using System;

namespace SUPLLY
{
	internal class Meter
	{
		internal World world;
		internal string ID;
		
		internal int meterSize;
		internal int[,] meterPos;

		internal bool isOccupied;
		internal bool isObject;

		internal string occupier;

		internal Meter( World world, int id, int ms, int[,] mp, bool od, bool ot, string oc )
		{
			this.world = world;
			this.ID = id;
			this.meterSize = SetMeterSize(ms);
			this.meterPos = GetMeterPos(mp, world);
			this.isOccupied = CollisionCheck(od);
			this.isObject = SetType(ot);
			this.occupier = GetColliderID(oc);
		}

		internal int SetMeterSize( int i )
		{
			return i;
		}

		internal int[] GetMeterPos( int[] x, int[,] world )
		{
			for ( int i = 0; i < world[0].Length(); i ++; )
			{
				for ( int j = 0; j < world[1].Length(); j ++ )
				{
					if ( x[0] == world[i] && x[1] == world[j] )
					{
						int[,] o = world[i,j];
					} else {
						Console.WriteLine("Error setting meter position");
						break;
					}
				}
			}
			return o;
		}

		internal bool SetType( bool x )
		{
			return x;
		}
	}
}
