<section id="produtos">
	<h2 class="titulo">Produtos</h2>
	<main class="container">
		<div class="row">
			<?php
			$array = [];
			$existe = false;
			foreach ($produtos as $key => $info) {

				foreach ($array as $jafoi) {
					if ($jafoi == $info['id_produtinho']) {
						$existe = true;
					}
				}

				array_push($array, $info['id_produtinho']);

				if ($existe == false) {

			?>
					<div class="col-lg-3 col-md-6 col-sm-12">
						<figure>
							<img src="./assets/img/<?= $info['imagem'] ?>" alt="poster do jogo Jedi Survivor" class="foto-produto">
							<figcaption>
								<h4><?= $info['titulo'], $info['id_produtinho'] ?> </h4>
								<span class="preco">R$<?= number_format($info['preco'], 2, ',') ?></span>
								<span class="avaliacao">
									<i class="bi bi-star-fill"></i>
									<i class="bi bi-star-fill"></i>
									<i class="bi bi-star-fill"></i>
									<i class="bi bi-star-half"></i>
									<i class="bi bi-star"></i>
								</span>
							</figcaption>
						</figure>
					</div>
			<?php
				}
				$existe = false;
			}
			?>
		</div>
	</main>
</section>