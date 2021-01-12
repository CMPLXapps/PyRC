__all__ = []
#----------------------------------------------------
class DEF_NETCLASS:
	def ROOM_conf(local_port, partner_port, partner_ipv4,  **kwargs):
		global NETCLASS
		class NETCLASS:
			class port:
				def __init__(self):
					self.local = local_port
					self.remote = partner_port
			class ipv4:
				def __init__(self):
					self.local = sock.gethostname()
					self.remote = partner_ipv4
			class ipv6:
				pass