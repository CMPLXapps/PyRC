class room:
	class host:
		def auth():
			pass
		def recieve():
			pass
	class client:
		pass
	class joining:
		pass
	def bcPublicMessage(msg):
		pass
class server:
	pass
class p2p:
	class dual_host:
		def establish:
			try:
				global NETCLASS, SERVER, CLIENT, ADDRESS
				SERVER = sock.socket(sock.AF_INET, sock.SOCK_STREAM)
				SERVER.bind((NETCLASS.ipv4.local, NETCLASS.port.local))
				def conn(conn_ip, conn_port):
					while True:
						try:
							SOCK.connect((conn_ip, conn_port))
							break
						except:
							continue
				thr.Thread(target=conn, args=(NETCLASS.ipv4.remote, NETCLASS.port.remote)).start()
				while True:
					SERVER.listen()
					CLIENT, ADDRESS = SERVER.accept()
					if ADDRESS[0] != NETCLASS.ipv4.remote:
						CLIENT.close()
				return '@CONN_SUCCEEDED $Connection Established!'
			except Exception as err:
				return f'@CONN_FAILED $An error occurred; connection not established: {err}'
	class single_host:
		pass