import { Box, Button, TextField, Typography } from '@mui/material'
import { Controller, SubmitHandler, useForm } from 'react-hook-form'
import { useMutation } from '@tanstack/react-query'
import { useNavigate } from 'react-router-dom'
import { useEffect } from 'react'
import { loginService } from '../../services/login'
import { LoginForm } from '../../shared/interfaces/loginForm'
import styles from './Login.module.scss'

const LoginPage = () => {
	const navigation = useNavigate()

	const { control, handleSubmit, reset } = useForm({
		defaultValues: {
			username: '',
			password: '',
		},
	})

	const mutation = useMutation({
		mutationFn: loginService.login,
	})

	const onSubmit: SubmitHandler<LoginForm> = userData => {
		mutation.mutate(userData)
		reset()
	}

	useEffect(() => {
		if (mutation.isSuccess && mutation.data?.id) {
			localStorage.setItem('UserData', JSON.stringify(mutation.data))
			navigation('/')
		}
	}, [mutation.data, mutation.isSuccess, navigation])

	return (
		<Box component='main' className={styles.main}>
			<img className={styles.logoImg} src='/fulllogo.svg' />
			<Box className={styles.container}>
				<Box className={styles.loginContainer}>
					<Typography component='h1' className={styles.title}>
						Войти
					</Typography>
					<form onSubmit={handleSubmit(onSubmit)} className={styles.form}>
						<Controller
							name='username'
							control={control}
							rules={{ required: true }}
							render={({ field }) => (
								<TextField
									{...field}
									label='Логин'
									autoComplete='off'
									InputLabelProps={{
										className: styles.inputLabelProps,
									}}
									InputProps={{
										className: styles.inputProps,
									}}
								/>
							)}
						/>
						<Controller
							name='password'
							control={control}
							rules={{ required: true }}
							render={({ field }) => (
								<TextField
									{...field}
									type='password'
									label='Пароль'
									autoComplete='off'
									InputLabelProps={{
										className: styles.inputLabelProps,
									}}
									InputProps={{
										className: styles.inputProps,
									}}
								/>
							)}
						/>
						<Button variant='contained' type='submit' className={styles.btn}>
							продолжить
						</Button>
					</form>
				</Box>
			</Box>
		</Box>
	)
}

export default LoginPage
